using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaParcial;

namespace MainParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Rocha Francisco";

            Auto auto1 = new Auto(4, "45AWD6", 4, EMarcas.Fiat);
            Auto auto2 = new Auto(4, "4WA6D5", 4, EMarcas.Ford);

            Moto moto1 = new Moto(4, "1FQ8W9", 2, EMarcas.Honda);
            Moto moto2 = new Moto(5, "Z8W9QA", 2, EMarcas.Iveco);

            Auto auto3 = new Auto(4, "2FAW46", 4, EMarcas.Fiat);

            Camion camion1 = new Camion(1500, "45AWD6", 8, EMarcas.Zanella);
            Camion camion2 = new Camion(2000, "45AWD6", 16, EMarcas.Scania);

            Lavadero miLavadero = new Lavadero(400, 800, 200);

            miLavadero += auto1;
            miLavadero += auto2;

            miLavadero += moto1;
            miLavadero += moto2;

            miLavadero += auto3;

            miLavadero += camion1;
            miLavadero += camion2;

            Console.Write(miLavadero.Avadero);
            Console.WriteLine(miLavadero.MostrarTotalFacturado()+ "\n\n");

            Console.WriteLine("Total facturado de autos: " + miLavadero.MostrarTotalFacturado(EVehiculos.Auto));
            Console.WriteLine("Total facturado de motos: " + miLavadero.MostrarTotalFacturado(EVehiculos.Moto));
            Console.WriteLine("Total facturado de camiones: " + miLavadero.MostrarTotalFacturado(EVehiculos.Camion));
            Console.WriteLine("\n");

            miLavadero += auto1;

            miLavadero -= auto2;
            miLavadero -= moto1;

            Console.Write(miLavadero.Avadero);
            Console.WriteLine(miLavadero.MostrarTotalFacturado() + "\n\n");

            Console.WriteLine("Total facturado de autos: " + miLavadero.MostrarTotalFacturado(EVehiculos.Auto));
            Console.WriteLine("Total facturado de motos: " + miLavadero.MostrarTotalFacturado(EVehiculos.Moto));
            Console.WriteLine("Total facturado de camiones: " + miLavadero.MostrarTotalFacturado(EVehiculos.Camion));
            Console.WriteLine("\n");

            Console.WriteLine("******************* ORDENAMIENTO POR MARCA ******************");
            miLavadero.Vehiculos.Sort(miLavadero.OrdenarVehiculosPorMarca);
            Console.Write(miLavadero.Avadero);

            Console.WriteLine("****************** ORDENAMIENTO POR PATENTE *****************");
            miLavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.Write(miLavadero.Avadero);

            Console.ReadKey(true);
        }
    }
}
