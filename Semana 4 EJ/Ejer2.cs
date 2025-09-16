using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4_EJ
{
    internal class Ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingres un año:");
            int annio = int.Parse(Console.ReadLine());
            if (annio%4==0 && annio % 100 != 0 || annio % 400==0)
            {
                Console.WriteLine("Año bisiesto");
            }
            else
            {
                Console.WriteLine("Año no bisiesto");
            }
            if (annio % 2 == 0)
            {
                Console.WriteLine("Año Par");
            }
            else
            {
                Console.WriteLine("Año Impar");
            }
            Console.ReadKey();
        }
    }
}
