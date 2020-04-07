using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Empleado
    {
        public string nombre;
        public string apellido;
        public int valorHora;
        public int horasTrabajadas;
        public int antiguedad;
        public int sueldoNeto;
        public int sueldoBruto;
        public int descuento;
        
        

        public void CrearEmpleado()
        {
            do
            {
                Console.WriteLine("ingrese el valor hora");
            } while (!(int.TryParse(Console.ReadLine(), out this.valorHora)));
            do
            {
                Console.WriteLine("ingrese la antiguedad del empleado");
            } while (!(int.TryParse(Console.ReadLine(), out this.antiguedad)));
            do
            {
                Console.WriteLine("ingrese la horas Trabajadas del empleado");
            } while (!(int.TryParse(Console.ReadLine(), out this.horasTrabajadas)));
            do
            {
                Console.WriteLine("ingrese el nombre del empleado");
                this.nombre = Console.ReadLine();
            } while (!Regex.IsMatch(this.nombre, @"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("ingrese el apellido del empleado");
                this.apellido = Console.ReadLine();
            } while (!Regex.IsMatch(this.apellido, @"^[a-zA-Z]+$"));



        }

        public int CalcularSueldo()
        {
            int sueldo;
            int antiguedadPaga = 150;
            int porcentaje = 13;
            int descuento;
            sueldo = valorHora * horasTrabajadas;
            sueldo +=antiguedadPaga*this.antiguedad;
            this.sueldoBruto = sueldo;
            descuento = (sueldo * porcentaje) / 100;
            this.descuento = descuento;
            sueldo -= descuento;
            this.sueldoNeto = sueldo;
            return sueldo;
        }

    }
}
