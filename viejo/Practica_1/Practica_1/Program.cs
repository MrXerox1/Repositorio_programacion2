using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona persona = new Persona();

      Persona persona2 = new Persona("mario", "Rodriguez", 30);

      Console.WriteLine("Apellido: {0}\nNombre: {1}\nEdad: {2}\n",persona2.apellido, persona2.nombre, persona2.GetEdad());

      persona2.CumplirAnios();

      Console.WriteLine("Apellido: {0}\nNombre: {1}\nEdad: {2}\n----Feliz cumpleaños----\n", persona2.apellido, persona2.nombre, persona2.GetEdad());


      Console.ReadLine();
    }
  }
}
