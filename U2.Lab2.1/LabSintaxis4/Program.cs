using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\nIngrese una opcion de las siguientes: (0 - Salir)");
                Console.WriteLine("1 - Funcion suma\n2 - Funcion biciesto\n3 - Funcion fibonacci\n4 - Pares desde el 1 al 100\n5 - Numero de mes\n6 - Pasaje a numero romano\n7 - N primeros numeros primos gemelos\n8 - Ingreso de clave\n9 - Piramide de caracteres");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        mostrarSuma();
                        break;
                    case 2:
                        esBiciesto();
                        break;
                    case 3:
                        Console.Write("Ingrese: ");
                        int nro = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"La suma de la serie de Fibonacci del nro {nro} es {fibonacci(nro)}");
                        break;
                    case 4:
                        paresHasta100();
                        break;
                    case 5:
                        numeroMes();
                        break;
                    case 6:
                        pasajeRomano();
                        break;
                    case 7:
                        nPrimosGemelos();
                        break;
                    case 8:
                        ingresoClave();
                        break;
                    case 9:
                        piramideCaracteres();
                        break;
                }
            } while (op != 0);
            

        }
        static void mostrarSuma() //El resultado de la suma de < número uno > y < número dos > es < resultado >
        {
            int nro1, nro2;
            Console.Write("Ingrese el primer numero: ");
            nro1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            nro2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma de {nro1} y {nro2} es: {nro1 + nro2}");
            Console.ReadKey();

        }

        static void esBiciesto()
        {
            Console.Write("Ingrese: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool band;
            if (year % 4 == 0)
            {
                if (year % 100 != 0) band = true;
                else if (year % 400 == 0) band = true;
                else band = false;
            }
            else band = false;
            if (band) Console.WriteLine($"El numero {year} es biciesto");
            else Console.WriteLine($"El numero {year} no es biciesto");
        }

        static int fibonacci(int nro)
        {
            if (nro == 1 | nro == 0) return 1;
            return fibonacci(nro - 1) + fibonacci(nro - 2);
        }

        static void paresHasta100()
        {
            Console.WriteLine("Numeros pares desde el 1 al 100: ");
            for(int i = 2; i <= 100; i = i + 2)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }

        static void numeroMes()
        {
            Console.Write("Ingrese nombre del mes: ");
            string mes = Console.ReadLine();
            string[] meses = new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            for(int i = 0; i < meses.Length; i++)
            {
                if(mes == meses[i]) Console.WriteLine($"El mes {mes} es el numero {i + 1}");
            }
        }

        static void pasajeRomano()
        {
            Console.Write("Ingrese un numero del 1 al 3999: ");
            int nro = Convert.ToInt32(Console.ReadLine()); ;
            string rom = "", miles, quinientos, centenas, cincuentas, decenas;
            int mil, qui, cent, cinc, dec;
            int nroOrig = nro;

            if(nro >= 1000)
            {
                mil = nro / 1000;
                nro = nro % 1000;
                miles = new string('M', mil);
                rom = rom + miles;
            }
            if(nro >= 500)
            {
                qui = nro / 500;
                nro = nro % 500;
                quinientos = new string('D', qui);
                rom = rom + quinientos;
            }
            if(nro >= 100)
            {
                cent = nro / 100;
                nro = nro % 100;
                if (cent <= 3)
                {
                    centenas = new string('C', cent);
                }
                else centenas = "CD";
                rom = rom + centenas;
            }
            if(nro >= 50)
            {
                cinc = nro / 50;
                nro = nro % 50;
                cincuentas = new string('L', cinc);
                rom = rom + cincuentas;
            }
            if(nro >= 10)
            {
                dec = nro / 10;
                nro = nro % 10;
                if(dec <= 3)
                {
                    decenas = new string('X', dec);
                }
                else decenas = "XL";
                rom = rom + decenas;
            }
            if(nro > 0)
            {
                string[] romanos = new string[10] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
                rom = rom + romanos[nro - 1];
            }
            Console.WriteLine($"El numero decimal {nroOrig} en romano es {rom}");
        }

        static void nPrimosGemelos()
        {
            Console.Write("Ingrese la cantidad de numeros: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int cantDivisores, cantPrimosGemelos;
            Console.WriteLine($"Los {n} primeros numeros primos gemelos: ");
            cantPrimosGemelos = 0;
            int i = 2;
            int ant = 1;
            while(cantPrimosGemelos < n)
            {
                cantDivisores = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0) cantDivisores += 1;
                }
                if (cantDivisores == 2)
                {
                    if (i - ant == 2)
                    {
                        Console.Write($"({ant},{i})\n");
                        cantPrimosGemelos += 1;
                    }
                    ant = i;
                }
                i++;
            }
        }

        static void ingresoClave()
        {
            Console.Write("Ingrese clave a validar: ");
            string claveCorrecta = Console.ReadLine();
            int intentos = 0;
            string clave = "";
            while (intentos < 4 & clave != claveCorrecta)
            {
                Console.Write("Ingrese la clave: ");
                clave = Console.ReadLine();
                intentos += 1;
            }
            if (clave != claveCorrecta) Console.WriteLine("Ha superado el numero de intentos permitidos.");
            else Console.WriteLine("Bienvenido al sistema!");
        }
        
        static void piramideCaracteres()
        {
            Console.Write("Ingrese el numero de filas: ");
            int nro = Convert.ToInt32(Console.ReadLine());
            int fila = 1;
            int cantCarac = 1;
            int cantEspacios = nro - 1;
            while (fila <= nro)
            {
                string espacios = new string(' ', cantEspacios);
                string caracteres = new string('*', cantCarac);
                Console.Write(espacios+caracteres+espacios+"\n");
                cantCarac += 2;
                cantEspacios -= 1;
                fila++;
            }
        }
    }
}
