using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de contraseñas a generar: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Password[] contrasenas = new Password[k];

            for (int i = 0; i < k; i++)
            {
                contrasenas[i] = new Password(longitud, rnd);
                Console.WriteLine("\nContraseña: " + contrasenas[i].Contrasena);
                Console.WriteLine("Es fuerte: " + contrasenas[i].Fuerte);
            }

            Console.ReadLine();

        }
    }
}
