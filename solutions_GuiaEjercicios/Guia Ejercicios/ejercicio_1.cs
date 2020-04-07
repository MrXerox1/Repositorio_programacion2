using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            int numeroMax=0;
            int numeroMin=0;
            int acumu=0;
            int promedio;
            int numero;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese n°:{0}", i+1);
                string aux = Console.ReadLine();

                if(int.TryParse(aux, out numero))
                {
                    acumu +=numero;
                    if (i == 0)
                    {
                        numeroMax = numero;
                        numeroMin = numero;
                    }
                    else if (numero>numeroMax)
                    {
                        numeroMax = numero;
                    }
                    else if (numero<numeroMin)
                    {
                        numeroMin = numero;
                    }
                }
            }
            promedio = acumu / i;
            Console.WriteLine("el numero maximo es: {0} y el minimo es: {1}, ademas tiene un promedio de {2}", numeroMax, numeroMin, promedio);
        }
    }
}
