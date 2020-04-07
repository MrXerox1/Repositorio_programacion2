using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            int numero;
            int espacios;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("ingrese el numero de pisos");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                sb.Append("*");
                for (int l = 0; l < numero*4; l++)
                {
                    
                    Console.Write(" ");
                }
                Console.WriteLine(sb);
                for (int i = 1; i < numero; i++)
                {
                    espacios = numero*4 - i;
                    for(int j=0;j<espacios ;j++ )
                    {
                        Console.Write(" ");
                    }
                    sb.Append("**");
                    Console.WriteLine(sb);
                }
            }
            Console.ReadKey();
        }
    }
}
