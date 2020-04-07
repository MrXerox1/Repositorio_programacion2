using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Instrumento
  {
    public string nombre;
    public TipoInstrumentos tipo;

    public Instrumento() { }

    public Instrumento(string nombre, TipoInstrumentos tipo)
    {
      this.nombre = nombre;
      this.tipo = tipo;
    }

    public enum TipoInstrumentos {viento, cuerda, percusion }

    public string getInstrumento()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("---Instrumento---\nNombre de instrumento: {0}\ntipo: {1}\n", this.nombre, this.tipo);
      return sb.ToString();
    }
  }
}
