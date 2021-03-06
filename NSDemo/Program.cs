﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обратите внимание на то, как класс CountDown
            // определяется с помощью пространства имен Counter.
            Counter.CountDown cd1 = new Counter.CountDown(10);
            int i;
            do
            {
                i = cd1.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();

            // Еще раз обратите внимание на то, как класс CountDown
            // определяется с помощью пространства имен Counter.
            Counter.CountDown cd2 = new Counter.CountDown(20);
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            cd2.Reset(4);
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
        }
    }
    }
}
