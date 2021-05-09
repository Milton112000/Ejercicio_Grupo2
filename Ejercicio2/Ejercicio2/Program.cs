using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            String Nombre;
            int edad;
            String Genero;

            Console.WriteLine("Introduzca su Nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Introduzca su Edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su Genero una (M) si es Hombre o una (F) si es Mujer ");
            Genero = Console.ReadLine();


            switch (Genero)
            {
                case "f" : Console.WriteLine("La Señora: "+Nombre+ " Se a Registrado");
                    break;

                case "F":
                    Console.WriteLine("La Señora: " + Nombre + " Se a Registrado");
                    break;

                case "m":
                    Console.WriteLine("El Señor: " + Nombre + " Se a Registrado");
                    break;

                case "M":
                    Console.WriteLine("El Señor: " + Nombre + " Se a Registrado");
                    break;

                default: Console.WriteLine("error en Datos Ingresados en Campo Genero");
                    break;
            }
            

            Console.ReadLine();
        }
    }
}
