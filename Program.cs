using System;
using System.Collections.Generic;
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
         class  Complex
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
            methodoverloading.Add(1, 2,6,7);
            Console.WriteLine("********************************************************");


            // operator overloading
            int result = 10 + 20; // this is normal addition
            string str1 = "Hello"+ "Demo";
            Console.WriteLine("result = "+result);
            Console.WriteLine("str1 = "+str1);

            //some rule of operator overloading
            // operator method must be declared as public static (operator +)
            // operator method must have one parameter of the class type
            // the operator can not overload - assignment operator (=, +=, -= etc), member access operator (.), conditional operator (?:), pointer member access operator (->), and the new and delete operators, keywords operator (typeof, sizdeof, checked etc), null conditional access (?.)

            // example - operator overloading +
            Complex complex1 = new Complex(10, 20);
            Complex complex2 = new Complex(10, 20);

            Complex complex3 = complex1 + complex2; // this will call the operator + method
            Console.WriteLine("complex3 real part = " + complex3.real + " complex3 imaginary part = " + complex3.imga);




        }
    }
}
