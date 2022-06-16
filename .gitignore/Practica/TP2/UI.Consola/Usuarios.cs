using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        Business.Logic.UsuarioLogic UsuarioNegocio;
        public Usuarios()
        {
            UsuarioNegocio = new Business.Logic.UsuarioLogic();
        }

        public void Menu()
        {
            ConsoleKeyInfo opcion;
            do {
                Console.Clear();
                Console.WriteLine("Listado de opciones: ");
                Console.WriteLine("\t1– Listado General");
                Console.WriteLine("\t2– Consulta");
                Console.WriteLine("\t3– Agregar");
                Console.WriteLine("\t4 - Modificar");
                Console.WriteLine("\t5 - Eliminar");
                Console.WriteLine("\t6 - Salir");
                


                do
                {
                    Console.WriteLine();
                    Console.Write("Ingrese una de las opciones: ");
                    opcion = Console.ReadKey();
                } while (opcion.Key != ConsoleKey.D1 & opcion.Key != ConsoleKey.D2 & opcion.Key != ConsoleKey.D3 & opcion.Key != ConsoleKey.D4 & opcion.Key != ConsoleKey.D5 & opcion.Key != ConsoleKey.D6);

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        ListadoGeneral();
                        break;
                    case ConsoleKey.D2:
                        Consultar();
                        break;
                    case ConsoleKey.D3:
                        Agregar();
                        break;
                    case ConsoleKey.D4:
                        Modificar();
                        break;
                    case ConsoleKey.D5:
                        Eliminar();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Hasta luego, gracias por su tiempo...");
                        break;

                }

            } while (opcion.Key != ConsoleKey.D6);
            Console.ReadKey();

        }

        private void ListadoGeneral()
        {
            Console.Clear();
            List<Usuario> users = UsuarioNegocio.GetAll();
            foreach (Usuario user in users)
            {
                MostrarDatos(user);
            }
            Console.ReadKey();
        }

        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese un id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Usuario user = UsuarioNegocio.GetOne(id);
                MostrarDatos(user);
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine("No existe un usuario con dicho id.");
            }
            catch (Exception e)
            {
                Console.WriteLine("El valor ingresado debe ser un numero entero.");
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private void MostrarDatos(Usuario user)
        {
                Console.WriteLine($"Usuario: {user.ID}");
                Console.WriteLine($"\t\tNombre: {user.Nombre}");
                Console.WriteLine($"\t\tApellido: {user.Apellido}");
                Console.WriteLine($"\t\tNombre de usuario: {user.NombreUsuario}");
                Console.WriteLine($"\t\tClave: {user.Clave}");
                Console.WriteLine($"\t\tEmail: {user.Email}");
                Console.WriteLine($"\t\tHabilitado: {user.Habilitado}");
                Console.WriteLine();
        }

        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese un id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Usuario user = UsuarioNegocio.GetOne(id);
                ConsoleKeyInfo opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Listado de opciones: ");
                    Console.WriteLine("\t1– Nombre");
                    Console.WriteLine("\t2– Apellido");
                    Console.WriteLine("\t3– Nombre de usuario");
                    Console.WriteLine("\t4 - Clave");
                    Console.WriteLine("\t5 - Email");
                    Console.WriteLine("\t6 - Habilitado");
                    Console.WriteLine("\t7 - Salir");




                    do
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese una de las opciones a modificar: ");
                        opcion = Console.ReadKey();
                    } while (opcion.Key != ConsoleKey.D1 & opcion.Key != ConsoleKey.D2 & opcion.Key != ConsoleKey.D3 & opcion.Key != ConsoleKey.D4 & opcion.Key != ConsoleKey.D5 & opcion.Key != ConsoleKey.D6 & opcion.Key != ConsoleKey.D7);
                    Console.WriteLine();
                    switch (opcion.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Write($"Nombre anterior: {user.Nombre}\t\tNombre nuevo: ");
                            user.Nombre = Console.ReadLine();
                            break;
                        case ConsoleKey.D2:
                            Console.Write($"Apellido anterior: {user.Apellido}\t\tApellido nuevo: ");
                            user.Apellido = Console.ReadLine();
                            break;
                        case ConsoleKey.D3:
                            Console.Write($"Nombre usuario anterior: {user.NombreUsuario}\t\tNombre usuario nuevo: ");
                            user.NombreUsuario = Console.ReadLine();
                            break;
                        case ConsoleKey.D4:
                            Console.Write($"Clave anterior: {user.Clave}\t\tClave nueva: ");
                            user.Clave = Convert.ToInt32(Console.ReadLine());
                            break;
                        case ConsoleKey.D5:
                            Console.Write($"Email anterior: {user.Email}\t\tEmail nuevo: ");
                            user.Email = Console.ReadLine();
                            break;
                        case ConsoleKey.D6:
                            Console.Write($"Habilitado anterior: {user.Habilitado}\t\tHabilitado nuevo (1-true / otro-false): ");
                            user.Habilitado = Console.ReadLine() == "1";
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Modificacion realizada.");
                            break;
                    }


                } while (opcion.Key != ConsoleKey.D7);
                user.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(user);
                Console.ReadKey();


            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine("No existe un usuario con dicho id.");
            }
            catch (Exception e)
            {
                Console.WriteLine("El valor ingresado debe ser un numero entero.");
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private void Agregar()
        {
            Usuario user = new Usuario();
            Console.Clear();
            Console.Write("Nombre: ");
            user.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            user.Apellido = Console.ReadLine();
            Console.Write("Nombre de usuario: ");
            user.NombreUsuario = Console.ReadLine();
            Console.Write("Clave: ");
            user.Clave = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            user.Email = Console.ReadLine();
            Console.Write("Habilitado (1-true / otro-false): ");
            user.Habilitado = Console.ReadLine() == "1";

            user.State = BusinessEntity.States.New;

            UsuarioNegocio.Save(user);

            Console.WriteLine();
            Console.WriteLine($"El usuario fue asignado con el id {user.ID}");
            Console.ReadKey();
        }

        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese un id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Usuario user = UsuarioNegocio.GetOne(id);

                UsuarioNegocio.Delete(id);

                user.State = BusinessEntity.States.Deleted;
                UsuarioNegocio.Save(user);
                Console.WriteLine();
                Console.WriteLine($"El usuario con el id {id} ha sido eliminado.");
                Console.ReadKey();

            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine("No existe un usuario con dicho id.");
            }
            catch (Exception e)
            {
                Console.WriteLine("El valor ingresado debe ser un numero entero.");
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
