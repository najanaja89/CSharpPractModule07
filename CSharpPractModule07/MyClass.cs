using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule07
{
    public class MyClass
    {
        public string String {set; get;}
        public int Int { set; get; }

        public MyClass(string str, int int_)
        {
            String = str;
            Int = int_;
        }

       public static bool operator !=(MyClass c1, MyClass c2)
        {
            Console.WriteLine("Operator != is working!");
            return !(c1.String == c2.String && c1.Int == c2.Int);
        }

        public static bool operator ==(MyClass c1, MyClass c2)
        {
            Console.WriteLine("Operator == is working!");
            return (c1.String == c2.String && c1.Int == c2.Int);
        }
    }
}
