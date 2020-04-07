using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Ejercicio_9
    {
        static void Main(string[] args)
        {
            int numero;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("ingrese el numero de pisos");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                sb.Append("*");
                Console.WriteLine(sb);
                for (int i = 1; i < numero; i++)
                {
                    sb.Append("**");
                    Console.WriteLine(sb);
                }
            }
            Console.ReadKey();
        }
    }
}
