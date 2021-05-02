using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PinturaSlack
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera temp1 = new Tempera(ConsoleColor.Red, "Hasbro", 5);
            Tempera temp2 = new Tempera(ConsoleColor.Blue, "Play color", 2);
            Tempera temp3 = new Tempera(ConsoleColor.Black, "Alba", 4);
            Tempera temp4 = new Tempera(ConsoleColor.Black, "Alba", 2);

            Console.WriteLine("Tempera 3: ");
            Console.WriteLine(Tempera.Mostrar(temp3));
            Console.WriteLine("\nTempera 2: ");
            Console.WriteLine(Tempera.Mostrar(temp2));
            Console.WriteLine("\nTempera 1: ");
            Console.WriteLine(Tempera.Mostrar(temp1));

            if(temp3 == temp4)
            {
                Console.WriteLine("\nSon iguales Tempera 3 y Tempera 4");
                Console.WriteLine("Tempera 4: ");
                Console.WriteLine(Tempera.Mostrar(temp4));
                Console.WriteLine("+");
                Console.WriteLine("\nTempera 3: ");
                Console.WriteLine(Tempera.Mostrar(temp3));
                Console.WriteLine("=");

                temp4 += temp3;
                Console.WriteLine("\nTempera 4: ");
                Console.WriteLine(Tempera.Mostrar(temp4));
            }

            temp4 += 5;
            Console.WriteLine("\nTempera 4: ");
            Console.WriteLine(Tempera.Mostrar(temp4));
            

            if(temp1 != temp4)
            {
                Console.WriteLine("\nTempera 1: ");
                Console.WriteLine(Tempera.Mostrar(temp1));

                temp1 += temp4;

                Console.WriteLine("\nTempera 1: ");
                Console.WriteLine(Tempera.Mostrar(temp1));

                Console.WriteLine("\nSon distintas Tempera 1 y Tempera 4 ");
            }

            Console.ReadKey(true);
        }
    }
}
