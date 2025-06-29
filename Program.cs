using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    internal class Program
    {
        class MethodOverloading
        {

            public void Add(int a, int b)
            {
                Console.WriteLine("a + b =" + (a + b));
            }
            public void Add(int a, int b, float c)
            {
                Console.WriteLine("a + b + c =" + (a + b + c));
            }
            public int Add(int a, int b, int c, int d)
            {
                Console.WriteLine("a + b + c + d =" + (a + b + c + d));
                return a + b + c + d;
            }

        }

        // example - operator overloading +
        class Complex
        {
            public double real { get; set; }
            public double imga { get; set; }
            public Complex(double r, double i)
            {
                real = r;
                imga = i;
            }

            // operator overloading
            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.real + c2.real, c1.imga + c2.imga);
            }
        }

        class Emp
        {
            public virtual void Name()
            {
                Console.WriteLine("Emp Name");
            }
        }
        class Manager : Emp
        {
            public override void Name()
            {
                Console.WriteLine("Manager Name");
            }
        }

        // Inheritance - This is the feature of OOPS. This allow one class(child) to inherite the properties and methods of another class.(derived)
        // child and derived class concept
        // Advantages - code reusability, implement polymorphism, organize the proper structure
        // Types of inheritance - C# supports single, multilevel, hierarchical inheritance
        // C# does not supports multiple inheritance (one class inheriting from multiple class). But we can achieve this by using interface


        // single inheritance - one class inhities the properties and methods from only one class

        class Parent1
        {
            public void Disaplay()
            {
                Console.WriteLine("This is parent");
            }

        }
        class Chiled1 : Parent1
        {
            public void Disaplay1()
            {
                Console.WriteLine("This is child");
            }
        }

        // Multilevel inhiritance - This is the inheritance where class is derived from another derived class. 
        // grandparent -> parent -> child

        class Grandparent
        {
            public void Disaplay()
            {
                Console.WriteLine("Grandparent");
            }
        }
        class Parent2 : Grandparent
        {
            public void Disaplay2()
            {
                Console.WriteLine("Parent1");
            }
        }
        class Child2 : Parent2
        {
            public void Disaplay3()
            {
                Console.WriteLine("Child2");
            }
        }

        //Hierarchical inheritance - This is the inheritance where multiple classes are derived from a single class.
        class Parent3
        {
            public void Disaplay()
            {
                Console.WriteLine("Parent3");
            }
        }

        class Child3 : Parent3
        {
            public void Disaplay1()
            {
                Console.WriteLine("Child3");
            }
        }
        class child4 : Parent3
        {
            public void Disaplay2()
            {
                Console.WriteLine("Child4");
            }

        }

        // multiple inheritance - This is the inheritance where class is derived from multiple classes. C# does not support this directly but we can achieve this by using interface.
        interface partrInterface
        {
            void Display();
        }
        interface childInterface : partrInterface
        {
            void Display1();
        }
        class Child5 : partrInterface, childInterface
        {

            public void Display()
            {
                Console.WriteLine("Child5 Display");
            }

            public void Display1()
            {
                Console.WriteLine("Child5 Display1");
            }
        }
        //protected constructor nad default 

        class Base1
        {
            protected Base1()
            {
                Console.WriteLine("Base1 constructor");
            }
        }

        class Div1 : Base1
        {
            public Div1()
            {
                Console.WriteLine("Div1 constructor");

            }
        }

        //Constructor overloading - Havinh multiple constructor in the same class, with different paramenter. This will allow you to create an object in different way.

        class AddClass
        {
            public AddClass(int a, int b)
            {
                Console.WriteLine($"{a + b}");
            }
            public AddClass(int a, int b, int c)
            {
                Console.WriteLine($"{a + b + c}");
            }
            public AddClass(int a, int b,int c, double d)
            {
                Console.WriteLine($"{a + b + c+ d}");
            }
        }


        class Base
        {
            protected Base(string name)
            {
                Console.WriteLine("Base constructor: " + name);
            }
        }

        class Derived : Base
        {
            public Derived(string name, int age, int rollNum) : base(name)
            {
                Console.WriteLine("Derived constructor: Age is " + age);
            }
        }

        static void Main(string[] args)
        {
            // Polymorphism - This is one of the concept for OOPS. This means one name many forms
            // Type of polymorphism - static and dynamic or compile time and run time polymorphism
            // Static polymorphism - Method overloading and operator overloading
            // Dynamic polymorphism - Method overriding

            //static polymorphism - Method overloading
            // normal example
            Console.WriteLine("********************************************************");
            Console.WriteLine("Static Polymorphism - Method Overloading");
            Console.WriteLine(1 + 2);

            MethodOverloading methodoverloading = new MethodOverloading();
            methodoverloading.Add(1, 2);
            methodoverloading.Add(1, 2, 8.9f);
            methodoverloading.Add(1, 2, 6, 7);
            Console.WriteLine("********************************************************");


            // operator overloading
            int result = 10 + 20; // this is normal addition
            string str1 = "Hello" + "Demo";
            Console.WriteLine("result = " + result);
            Console.WriteLine("str1 = " + str1);

            //some rule of operator overloading
            // operator method must be declared as public static (operator +)
            // operator method must have one parameter of the class type
            // the operator can not overload - assignment operator (=, +=, -= etc), member access operator (.), conditional operator (?:), pointer member access operator (->), and the new and delete operators, keywords operator (typeof, sizdeof, checked etc), null conditional access (?.)

            // example - operator overloading +
            Complex complex1 = new Complex(10, 20);
            Complex complex2 = new Complex(10, 20);

            Complex complex3 = complex1 + complex2; // this will call the operator + method.ch
            Console.WriteLine("complex3 real part = " + complex3.real + " complex3 imaginary part = " + complex3.imga);


            // dynamic binding/ polymorphism - Method overriding
            //Requires virtual method in the base class and override the m=virtual method in the derived class. 
            // It relates to inheritance 

            Emp emp = new Emp();
            emp.Name(); // this will call the base class method
            Emp emp2 = new Manager();
            emp2.Name(); // this will call the derived class method due to dynamic binding

            //Inheritance 
            //Single Inheritance
            Chiled1 chiled1 = new Chiled1();
            chiled1.Disaplay(); // this will call the parent class method
            chiled1.Disaplay1(); // this will call the child class method

            Parent1 p = new Chiled1();
            p.Disaplay(); // this will call the parent calss method , if we want to call child method then use virtual and override keywords

            // Multilevel inhiritance 
            Child2 child2 = new Child2();
            child2.Disaplay();
            child2.Disaplay2();
            child2.Disaplay3();

            //Hierarchical inheritance

            Child3 child3 = new Child3();
            child3.Disaplay();
            child3.Disaplay1();
            child4 child4 = new child4();
            child4.Disaplay();
            child4.Disaplay2();

            // Multiple inheritane
            Child5 child5 = new Child5();
            child5.Display(); // this will call the interface method
            child5.Display1(); // this will call the interface method   

            // Constructors role in inheritance 
            // calls the base constructor first then child 
            // Private constructor - cannot be inherited
            // Protected constructor - can be inherited by the derived class

            // Protected and Default constructor 
            Div1 div1 = new Div1();

            //  protected contructor and parameterized
            Derived d = new Derived("Neha", 25, 24);


            //Constructor overloading - Havinh multiple constructor in the same class, with different paramenter. This will allow you to create an object in different way.
            AddClass obj1 = new AddClass(5, 10);               // Calls 2-parameter constructor
            AddClass obj2 = new AddClass(1, 2, 3);             // Calls 3-parameter constructor
            AddClass obj3 = new AddClass(1, 2, 3, 4.5);

        }
    }
}
