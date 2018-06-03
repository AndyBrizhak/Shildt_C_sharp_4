using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte b = -34;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            Console.ReadKey();

            // обратить все биты
            b = (sbyte)~b;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }
            Console.ReadKey();
        }
    }
}
