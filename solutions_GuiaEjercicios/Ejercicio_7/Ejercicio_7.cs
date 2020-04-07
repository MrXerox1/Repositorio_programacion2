using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Ejercicio_7
    {
        static void Main(string[] args)
        {
            DateTime FechaActual = DateTime.Now;
            DateTime fechaNacimiento;
            string fechaString;
            int fecha;
            int dias;


            do
            {
                do
                {
                    Console.WriteLine("ingrese la dia de nacimiento formato DD");
                } while (!(int.TryParse(Console.ReadLine(), out fecha)));

            } while (!(fecha >= 1 && fecha <= 31));
            StringBuilder sb = new StringBuilder();
            sb.Append(fecha + "/");
            do
            {
                do
                {
                    Console.WriteLine("ingrese el mes de nacimiento formato MM");
                } while (!(int.TryParse(Console.ReadLine(), out fecha)));

            } while (!(fecha >= 1 && fecha <= 12));
            sb.Append(fecha + "/");
            do
            {
                do
                {
                    Console.WriteLine("ingrese el mes de nacimiento formato AAAA");
                } while (!(int.TryParse(Console.ReadLine(), out fecha)));

            } while (!(fecha >= 1000 && fecha <= FechaActual.Year));

            sb.Append(fecha);
            fechaString = sb.ToString();
            Fechas validar = new Fechas();
            if (validar.EsFecha(fechaString)) 
            {
                fechaNacimiento = DateTime.Parse(fechaString);
                TimeSpan ts = FechaActual - fechaNacimiento;
                dias = ts.Days;
                System.Console.WriteLine("los dias vividos desde {1} son {0} ", dias, fechaString);
            }
            else
            {
                Console.WriteLine("La fecha ingresada es incorrecta");
            }
            Console.ReadKey();
        }
    }
}
