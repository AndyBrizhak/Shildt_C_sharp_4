using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int S=0;
            if (S > 3) Console.WriteLine(S); else Console.WriteLine("3");
            Console.ReadKey();

            //uint width = 100;   if(DateTime.Now.Minute  >=0) && (DateTime.Now.Minute<=30)   width = 50;

            if (!(Console.ReadLine()==".")) { Console.WriteLine("Ожидайте...."); }
            Console.ReadKey();

            bool flag = true && !false; string outData = "";    if (flag != true) { outData = "Data Correct"; }
            Console.ReadKey();

            //double l = Convert.ToInt32(Console.ReadLine()); if (l = 2.5) Console.WriteLine("var 1"); else Console.WriteLine("var 2");



        }
    }
}
