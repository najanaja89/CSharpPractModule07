using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule07
{
    public class MyArray
    {
        Random rand = new Random();
        public int[] array;
        public MyArray(int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 125);
            }
        }

        public static bool operator < (MyArray a1, MyArray a2)
        {
            Console.WriteLine("Operator < is working!");
            return (a1.array.Cast<int>().Sum() < a2.array.Cast<int>().Sum());
        }

        public static bool operator > (MyArray a1, MyArray a2)
        {
            Console.WriteLine("Operator > is working!");
            return (a1.array.Cast<int>().Sum() > a2.array.Cast<int>().Sum());
        }
        
    }
}
