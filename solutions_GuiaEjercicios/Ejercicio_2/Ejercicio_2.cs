using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;
            Console.WriteLine("ingrese el numero");
            string aux = Console.ReadLine();

            if (double.TryParse(aux, out numero))
            {
                if (numero == 0)
                {
                    Console.WriteLine("error no puede ingresar un 0");
                    return;
                }
                cuadrado = Math.Pow(numero, 2);
                Console.WriteLine("el cuadrado del numero es: {0}",cuadrado);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("el cubo del numero es: {0}",cubo);
            }
        }
    }
}
