using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaParcial;

namespace BibliotecaParcial
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioMoto = 0;
        private float precioAutos = 0;
        private float precioCamnion = 0;
        

        private Lavadero()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioA, float precioC, float precioM) : this()
        {
            this.precioMoto = precioM;
            this.precioAutos = precioA;
            this.precioCamnion = precioC;
        }

        public string Avadero
        {
            get { 
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\n******************** PRECIO POR VEHICULO ********************\n");

                sb.AppendLine("Precio auto: " + this.precioAutos);
                sb.AppendLine("Precio camion: " + this.precioCamnion);
                sb.AppendLine("Precio moto: " + this.precioMoto);

                sb.AppendLine("\n******************** LISTA DE VEHICULOS ********************\n");

                foreach (Vehiculo item in Vehiculos)
                {
                    if (item is Auto auto)
                    {
                        sb.AppendLine(auto.MostrarAuto());
                    }
                    else if (item is Camion camion)
                    {
                        sb.AppendLine(camion.MostrarCamion());
                    }
                    else if (item is Moto moto)
                    {
                        sb.AppendLine(moto.MostrarMoto());
                    }
                }

                return sb.ToString();
                }
        }
        public List<Vehiculo> Vehiculos 
        { 
            get 
            { 
                return this.vehiculos; 
            } 
        }

        public double MostrarTotalFacturado()
        {
            float retorno = 0;

            Console.Write("TOTAL FACTURADO: ");

            foreach (Vehiculo vehiculito in vehiculos)
            {
                if (vehiculito is Auto)
                {
                    retorno += this.precioAutos;
                }
                else if (vehiculito is Camion)
                {
                    retorno += this.precioCamnion;
                }
                else if (vehiculito is Moto)
                {
                    retorno += this.precioMoto;
                }
            }

            return retorno;
        }

        public double MostrarTotalFacturado(EVehiculos unVehiculo)
        {
            float retorno = 0;
            foreach (Vehiculo vehiculito in vehiculos)
            {
                if(unVehiculo == EVehiculos.Auto && vehiculito is Auto)
                {
                    retorno += this.precioAutos;
                }
                else if(unVehiculo == EVehiculos.Camion && vehiculito is Camion) 
                {
                    retorno += this.precioCamnion;
                }
                else if(unVehiculo == EVehiculos.Moto && vehiculito is Moto)
                {
                    retorno += this.precioMoto;
                }
            }

            return (double)retorno;
        }

        public static bool operator ==(Lavadero Lava, Vehiculo Vehi)
        {
            bool retorno = false;

            if (((object)Lava) == null && ((object)Vehi) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)Lava) != null && ((object)Vehi) != null)
                {
                    foreach (Vehiculo vehiculito in Lava.vehiculos)
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

        public static bool operator !=(Lavadero Lava, Vehiculo Vehi)
        {
            return !(Lava == Vehi);
        }

        public static Lavadero operator +(Lavadero Lava, Vehiculo Vehi)
        {
            if (Lava != Vehi)
            {
                Console.WriteLine("Se dio de alta el vehiculo...");
                Lava.vehiculos.Add(Vehi);
            }
            
            return Lava;
        }

        public static Lavadero operator -(Lavadero Lava, Vehiculo Vehi)
        {
            if (Lava == Vehi)
            {
                Console.WriteLine("Se dio de baja el vehiculo...");
                Lava.vehiculos.Remove(Vehi);
            }

            return Lava;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo vehi1, Vehiculo vehi2)
        {
            return string.Compare(vehi1.Patente, vehi2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo vehi1, Vehiculo vehi2)
        {
            return string.Compare(vehi1.Marca.ToString(), vehi2.Marca.ToString());
        }
    }
}
