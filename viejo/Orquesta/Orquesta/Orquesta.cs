using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Orquesta
  {
    public string nombre;
    public string lugar;
    public List<Musico> musicos;  
    public TipoOrquesta tipo;

    public Orquesta() { }

    public Orquesta(string nombre, string lugar, TipoOrquesta orquesta)
    {
      this.nombre = nombre;
      this.lugar = lugar;
      this.tipo = orquesta;
      this.musicos = new List<Musico>();
    }

    public enum TipoOrquesta{sinfonica, camara, filarmonica}

    public string GetNombre()
    {
      return this.nombre;
    }

    public string Getlugar()
    {
      return this.lugar;
    }

    public TipoOrquesta GetTipo()
    {
      return this.tipo;
    }

    public string GetOrquesta()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("---Orquesta---\nNombre de orquesta: {0}\nLugar: {1}\ntipo de orquesta: {2}", this.nombre, this.lugar, this.tipo);
      return sb.ToString();
    }

    public static void ImprimirOrquesta(Orquesta orquesta)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(orquesta.GetOrquesta());

      if (orquesta.musicos.Count > 0)
      {
        sb.AppendFormat("---lista Musicos--- \n");
        foreach (Musico Element in orquesta.musicos)
        {
          sb.AppendFormat("-musico--\nNombre: {0}\n",Element.nombre);
          sb.AppendFormat("instrumento: {0}\n", Element.instrumento.nombre);
        }
      }
      Console.WriteLine("{0}", sb.ToString());
      Console.ReadLine();

    }
  }
}
