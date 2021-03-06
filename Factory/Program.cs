﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class MyClass
    {
        int a, b;
        // Создать фабрику для класса MyClass.
        static public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t; // возвратить объект
        }

        public void Show()
        {
            Console.WriteLine("а и b: " + a + " " + b);
        }
    }


    class MakeObjects
    {
        static void Main(string[] args)
        {
            int i, j;
            // Сформировать объекты, используя фабрику.
            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass ob = MyClass.Factory(i, j); // создать объект
                ob.Show();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
