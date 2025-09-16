using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4_EJ
{
    internal class Ejer4
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenidos al calculo de areas\n");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo");
            Console.Write("Ingrese una opcion:");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:Console.Write("\nIngrese su lado:");
                    int lado= int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea:" + (lado * lado));
                    break;
                case 2: Console.Write("\nIngrese su base:");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese su altura:");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea:" + (bse * alt));
                    break;
                case 3: Console.Write("\nIngrese su base:");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese su altura:");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea:" + (bse2 * alt2));
                    break;
                case 4: Console.Write("\nIngrese su radio:");
                    double radio = double.Parse(Console.ReadLine());
                    Console.Write("\nIngrese su altura:");
                    int rad = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea:" + Math.Round(Math.PI * (radio * radio), 2));
                    break;
                default:Console.WriteLine("\nOpcion incorrecta");
                    break;
            }
        }
    }
}
