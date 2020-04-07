using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            int fechaInicio;
            int fechaFinal;
            int resto;
            int flag;
            do 
            {
                Console.WriteLine("ingrese la fecha minima");
                int.TryParse(Console.ReadLine(), out fechaInicio);
            } while(!(fechaInicio>0));
            do
            {
                Console.WriteLine("ingrese la fecha maxima");
                int.TryParse(Console.ReadLine(), out fechaFinal);
            } while (fechaInicio >fechaFinal);

            for (int i = fechaInicio ; i <= fechaFinal; i++)
            {
                flag = 0;
                resto = i % 4;
                if (resto == 0)
                {
                    flag = 1;
                    resto = i % 100;

                    if (resto != 0)
                    {
                        flag = 1;
                    }
                    else if (resto == 0)
                    {
                        flag = 0;
                        resto = i % 400;
                        if (resto == 0)
                        {
                            flag = 1;
                        }
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("{0} es un año bisiesto", i);
                }
            }
            Console.ReadKey();
        }
    }
}
