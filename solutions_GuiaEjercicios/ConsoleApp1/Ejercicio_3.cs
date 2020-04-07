using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            int numero;
            int divisor = 2;
            int resto;
            bool flag =true;

            Console.WriteLine("ingrese el numero");
            string aux = Console.ReadLine();
            if (int.TryParse(aux, out numero))
            {
                for (int i = 2; i < numero; i++)
                {
                    divisor = 2;
                    while (divisor < i)
                    {
                        flag = true;
                        resto = i % divisor;
                        if (resto == 0)
                        {
                            flag = false;
                            break;
                        }
                        divisor += 1;
                    }
                    if (flag)
                    {
                        
                        Console.WriteLine(i);
                    }

                }
            }
            Console.WriteLine("estos son todos los numeros primos");
            Console.ReadKey();
        }
    }
}
