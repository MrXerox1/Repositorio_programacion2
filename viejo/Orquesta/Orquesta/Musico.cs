using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Musico
  {
    public string nombre;
    public string apellido;
    public int edad;
    public Instrumento instrumento;
   // public Orquesta orquesta ;

    public Musico(string nombre, string apellido, int edad,Instrumento instrumento)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
      this.instrumento = instrumento;
    //  this.orquesta = orquesta;
    }

  }
}
