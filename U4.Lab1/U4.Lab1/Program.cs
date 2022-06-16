using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace U4.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            leerConFileStream();
            Console.WriteLine();
            leerConStreamReader();
            Console.WriteLine();
            escribir();

            Console.ReadKey();
        }

        private static void leerConFileStream()
        {
            Console.WriteLine("Utilizando FileStream: ");
            FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            lector.Close();
        }

        private static void leerConStreamReader()
        {
            Console.WriteLine("Utilizando StreamReader: ");
            StreamReader lector2 = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\tMail\t\t\tTelefono");
            do
            {
                linea = lector2.ReadLine();

                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine($"{valores[0]}\t{valores[1]}\t{valores[2]}\t{valores[3]}");
                }
            } while (linea != null);

            lector2.Close();
        }

        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevos contactos");
            string op;
            do
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Mail: ");
                string mail = Console.ReadLine();
                Console.Write("Telefono: ");
                string telefono = Console.ReadLine();

                escritor.WriteLine(nombre + ';' + apellido + ';' + mail + ';' + telefono);

                Console.Write("Desea seguir? (s - SI / n - NO): ");
                op = Console.ReadLine();

            } while (op == "s");

            escritor.Close();
        }
    }
}
