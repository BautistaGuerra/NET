using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2._3._4
{
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            do
            {
                Console.Write("Indique la cantidad de empleados que desea ingresar: ");
                cant = Convert.ToInt32(Console.ReadLine());
            } while (cant <= 0);

            var empleados = new List<Empleado>();
            Console.WriteLine();
            Console.WriteLine("Ingrese Id, Nombre y sueldo de los empleados: ");
            for(int i = 1; i <= cant; i++)
            {
                Empleado emp = new Empleado();
                Console.WriteLine($"Empleado {i}: ");
                Console.Write("Id: ");
                emp.IdEmpleado = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nombre: ");
                emp.Nombre = Console.ReadLine();
                Console.Write("Sueldo: ");
                emp.Sueldo = Convert.ToDecimal(Console.ReadLine());

                empleados.Add(emp);
                Console.WriteLine();
            }

            var empleadosAscendente = empleados.OrderBy(e => e.Sueldo);

            var empleadosDescendente = empleados.OrderByDescending(e => e.Sueldo);

            Console.WriteLine();
            Console.WriteLine("Empleados ordenados por sueldo de manera ascendente: ");
            foreach(var e in empleadosAscendente)
            {
                Console.WriteLine($"Sueldo: {e.Sueldo}\tId: {e.IdEmpleado}\tNombre: {e.Nombre}");
            }

            Console.WriteLine();
            Console.WriteLine("Empleados ordenados por sueldo de manera descendente: ");
            foreach (var e in empleadosDescendente)
            {
                Console.WriteLine($"Sueldo: {e.Sueldo}\tId: {e.IdEmpleado}\tNombre: {e.Nombre}");
            }

            Console.ReadKey();


        }
    }
}
