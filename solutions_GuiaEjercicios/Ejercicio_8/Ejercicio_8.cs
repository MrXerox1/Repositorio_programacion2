﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio_8
{
    class Ejercicio_8
    {
        static void Main(string[] args)
        {
            string respuesta;
            bool flag;
            Empleado empleado = new Empleado();
            List<Empleado> empleadosLista = new List<Empleado>();
            do 
            {
                flag=true;
                empleado.CrearEmpleado();
                empleado.CalcularSueldo();
                empleadosLista.Add(empleado);
                Console.WriteLine("quiere ingresar otro empleado? s/n");
                respuesta = Console.ReadLine();
            }
            while (respuesta != "n");
            foreach (Empleado aEmpleado in empleadosLista)
            {
                Console.WriteLine("Nombre: {0} {1}\nAntiguedad: {2}\nValor hora: {3}", aEmpleado.nombre, aEmpleado.apellido, aEmpleado.antiguedad, aEmpleado.valorHora);
                Console.WriteLine("sueldo bruto: {0}\nDescuento: {1}\nSueldo Neto: {2}\n", aEmpleado.sueldoBruto, aEmpleado.descuento, aEmpleado.sueldoNeto);
            }
           Console.ReadKey();
        }
    }
}
