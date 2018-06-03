using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num;
            num = 10;

            if ((num & 1) == 1)
                Console.WriteLine("He выводится.");
            num = 11;
            if ((num & 1) == 1)
                Console.WriteLine(num + " — нечетное число.");
            Console.ReadKey();
        }
    }
}
