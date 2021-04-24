using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaParcial
{
    public class Vehiculo
    {
        protected Byte cantRuedas;
        protected readonly EMarcas marca;
        private readonly string patente;

        public string Patente
        {
            get { return this.patente; }
        }

        public EMarcas Marca
        {
            get { return this.marca; }
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: "+ this.marca);
            sb.AppendLine("Cantidad de ruedas : " + this.cantRuedas);
            sb.AppendLine("Patente: " + this.patente);  

            return sb.ToString();
        }

        public Vehiculo(string patente, Byte ruedas, EMarcas marca)
        {
            this.marca = marca;
            this.patente = patente;
            this.cantRuedas = ruedas;
        }

        public static bool operator ==(Vehiculo veh1, Vehiculo veh2)
        {
            bool retorno = false;

            if (((object)veh1) == null && ((object)veh2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)veh1) != null && ((object)veh2) != null)
                {
                    if (veh1.patente == veh2.patente && veh1.marca == veh2.marca)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo veh1, Vehiculo veh2)
        {
            return !(veh1 == veh2);
        }
    }
}
