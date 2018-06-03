using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            byte val;
            val = 123;
            for (t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }
            Console.ReadKey();
        }
    }
}
