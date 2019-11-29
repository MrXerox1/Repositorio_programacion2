using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Program
  {
    static void Main(string[] args)
    {
      Orquesta orquesta = new Orquesta("filarmonica avellaneda","Avellaneda", Orquesta.TipoOrquesta.filarmonica);
      Instrumento instrumento = new Instrumento("Flauta", Instrumento.TipoInstrumentos.viento);
      Musico musico = new Musico("pepe", "mujica", 40, instrumento);

      Console.WriteLine("nombre: {0}\nlugar: {1}\ntipo: {2}", orquesta.nombre, orquesta.lugar, orquesta.tipo);

      Console.WriteLine("nombre: {0}\ntipo: {1}", instrumento.nombre, instrumento.tipo);

      Console.WriteLine("\n-----musico----\nNombre: {0}\nApellido: {1}\nEdad: {2}\n{3}\n", musico.nombre, musico.apellido, musico.edad, musico.instrumento.getInstrumento());

      Console.ReadLine();

      Instrumento instrumento2 = new Instrumento("guitarra", Instrumento.TipoInstrumentos.cuerda);
      Musico musico2 = new Musico("marcelo", "grillo", 24, instrumento2);

      orquesta.musicos.Add(musico);
      orquesta.musicos.Add(musico2);
      Orquesta.ImprimirOrquesta(orquesta);

      Console.ReadLine();

    }
  }
}
