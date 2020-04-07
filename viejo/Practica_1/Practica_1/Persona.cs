using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
  class Persona
  {
    private int edad;
    public string nombre;
    public string apellido;


    public Persona() { }

    public Persona(string nombre, string apellido, int edad)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
    }

    public void SetEdad(int edad)
    {
      this.edad = edad;
    }

    public int GetEdad()
    {
      return  this.edad;
    }

    public void CumplirAnios()
    {
      this.edad++;
    }

  }
}
