using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultDiv
{
    class MultDiv
    {
        static void Main(string[] args)
        {
            int n;
            n = 10;

            Console.WriteLine("Значение переменной n: " + n);

            // Умножить на 2.
            n = n << 1;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n * 2: " + n);
            Console.ReadKey();

            // Умножить на 4.
            n = n << 2;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n * 4: " + n);
            Console.ReadKey();

            // Разделить на 2.
            n = n >> 1;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n / 2: " + n);
            Console.ReadKey();

            // Разделить на 4.
            n = n >> 2;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n / 4: " + n);
            Console.WriteLine();
            Console.ReadKey();

            // Установить переменную n в исходное состояние.
            n = 10;
            Console.WriteLine("Значение переменной n: " + n);
            Console.ReadKey();

            // Умножить на 2 тридцать раз.
            n = n << 30; // данные теряются
            Console.WriteLine("Значение переменной п после " +
            "сдвига на 30 позиций влево: " + n);
            Console.ReadKey();

        }
    }
}
