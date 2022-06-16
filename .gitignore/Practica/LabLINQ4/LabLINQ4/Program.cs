using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabLINQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            Console.Write("Indique la cant de empleados a ingresar: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Ingrese los {cant} empleados: ");
            for(int i = 1; i <= cant; i++)
            {
                Console.WriteLine($"Emp {i}: ");
                Console.Write("Nombre: ");
                string nom = Console.ReadLine();
                Console.Write("Sueldo: ");
                decimal sueldo = Convert.ToDecimal(Console.ReadLine());
                empleados.Add(new Empleado { Nombre = nom, Sueldo = sueldo, Id = i });
            }
            Console.WriteLine();

            var empleadosAsc = empleados.OrderBy(e => e.Sueldo);
            var empleadosDesc = empleados.OrderByDescending(e => e.Sueldo);

            Console.WriteLine("Empleados ordenados ascendentemente por sueldo: ");
            foreach (Empleado emp in empleadosAsc)
            {
                Console.WriteLine($"\tId: {emp.Id}\tNombre: {emp.Nombre}\tSueldo: {emp.Sueldo}");
            }
            Console.WriteLine();

            Console.WriteLine("Empleados ordenados descendentemente por sueldo: ");
            foreach (Empleado emp in empleadosDesc)
            {
                Console.WriteLine($"\tId: {emp.Id}\tNombre: {emp.Nombre}\tSueldo: {emp.Sueldo}");
            }
            Console.ReadKey();
        }
    }
}
