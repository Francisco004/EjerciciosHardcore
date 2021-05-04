using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        private string nombre;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacio) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacio;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n\nEstacionamiento " + e.nombre);

            sb.AppendLine("Espacio disponible: " + e.espacioDisponible);
            sb.AppendLine("\n");

            foreach (Vehiculo vehiculos in e.vehiculos)
            {
                sb.AppendLine(vehiculos.ConsultarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo Vehi)
        {
            bool retorno = false;

            if (((object)estacionamiento) == null && ((object)Vehi) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)estacionamiento) != null && ((object)Vehi) != null)
                {
                    foreach (Vehiculo vehiculito in estacionamiento.vehiculos)
                    {
                        if (vehiculito == Vehi)
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo Vehi)
        {
            return !(estacionamiento == Vehi);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo Vehi)
        {
            if (estacionamiento != Vehi && Vehi.Patente != null && estacionamiento.vehiculos.Count() <= estacionamiento.espacioDisponible)
            {
                Console.WriteLine("Se agrego el vehiculo al estacionamiento...");
                estacionamiento.vehiculos.Add(Vehi);
            }
            else
            {
                Console.WriteLine("No hay espacio en el estacionamiento o el vehiculo ya se encuentra en este...");
            }

            return estacionamiento;
        }
        
        public static string operator -(Estacionamiento estacionamiento, Vehiculo Vehi)
        {
            string retu;

            if (estacionamiento == Vehi)
            {
                retu = "\nSe dio de baja el vehiculo " + Vehi.ImprimirTicket();

                estacionamiento.vehiculos.Remove(Vehi);
            }
            else
            {
                retu = "\nEl vehículo no es parte del estacionamiento...";
            }

            return retu;
        }
    }
}
