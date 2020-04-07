using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            int resto;
            int contador = 1;
            int acum= 0;
            int numero = 1;

                while(contador<=4)
                {
                    acum = 0;

                    for (int i = 1; i < numero; i++)
                    {
                        resto = numero%i;
                        if (resto == 0)
                        {
                            acum += i;
                        }
                    }
                    if (acum == numero)
                    {
                        acum = 0;
                        contador++;
                        Console.WriteLine("El numero {0} es un numero perfecto",numero);
                    }

                    numero++;    
                }

            Console.ReadKey();
        }
    }
}
