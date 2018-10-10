using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpPractModule07
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass("string1", 1);
            MyClass c2 = new MyClass("string1", 1);
            MyClass c3 = new MyClass("string2", 1);

            if (c1==c2)
            {
                Console.WriteLine("Objects are equal!");
            }
            Console.WriteLine();
            if (c1!=c3)
            {
                Console.WriteLine("Objects are not equal!");
            }

            Console.WriteLine();

            MyArray a1 = new MyArray(10);
            Thread.Sleep(500);
            MyArray a2 = new MyArray(10);

            if (a1 > a2) Console.WriteLine("Object a1 bigger than a2!");
            Console.WriteLine();
            if (a1 < a2) Console.WriteLine("Object a1 smaller than a2!");

            Console.ReadLine();
        }
    }
}
