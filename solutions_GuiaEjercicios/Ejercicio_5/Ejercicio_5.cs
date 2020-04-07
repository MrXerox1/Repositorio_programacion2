using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            int numero;
            int contador=2;
            int sumaPositivo=0;
            int sumaNegativo=0;
            Console.WriteLine("ingrese el numero");
            string aux = Console.ReadLine();
            if (int.TryParse(aux, out numero))
            {
                do
                {
                    for (int i = 1; i < contador; i++)
                    {
                        sumaPositivo += i;

                    }
                    for (int j = contador + 1; sumaNegativo < sumaPositivo; j++)
                    {
                        sumaNegativo += j;
                    }
                    if (sumaPositivo == sumaNegativo)
                    {
                        Console.WriteLine("felicidades {0} es un centro numerico", contador);
                    }
                    contador++;
                    sumaNegativo = 0;
                    sumaPositivo = 0;
                } while (contador<=numero);
            }
            Console.ReadKey();
        }
    }
}
