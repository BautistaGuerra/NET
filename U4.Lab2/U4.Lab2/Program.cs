using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace U4.Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejadorArchivo manejadorArch;

            Console.WriteLine("Elija el modo: ");
            Console.WriteLine("1 - TXT");
            Console.WriteLine("1 - XML");
            if(Console.ReadLine() == "2")
            {
                manejadorArch = new ManejarArchivoXml();
            }
            else
            {
                manejadorArch = new ManejarArchivoTxt();
            }
            manejadorArch.listar();
            menu(manejadorArch);
        }

        public static void menu(ManejadorArchivo manejadorArch)
        {
            string rta = "";

            do
            {
                Console.WriteLine("1- Listar\n2- Agregar\n3- Modificar\n4- Eliminar\n5- Guardar cambios\n6- Salir");
                rta = Console.ReadLine();
                switch (rta)
                {
                    case "1":
                        manejadorArch.listar();
                        break;
                    case "2":
                        manejadorArch.nuevaFila();
                        break;
                    case "3":
                        manejadorArch.editarFila();
                        break;
                    case "4":
                        manejadorArch.eliminarFila();
                        break;
                    case "5":
                        manejadorArch.aplicaCambios();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Gracias por su tiempo...");
                        break;

                }
            } while (rta != "6");
        }
    }
}
