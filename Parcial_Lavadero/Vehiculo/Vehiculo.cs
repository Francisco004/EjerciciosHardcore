using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaParcial
{
    public class Vehiculo
    {
        protected Byte CantRuedas;
        protected readonly EVehiculos marca;
        private readonly string patente;

        public string Patente
        {
            get { return this.patente; }
        }

        public EVehiculos Marca
        {
            get { return this.marca; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("_marca: "+ this.marca);
            sb.AppendLine("Cantidad de ruedas : " + this.CantRuedas);
            sb.AppendLine("_patente: " + this.patente);  

            return sb.ToString();
        }

        public Vehiculo(string patente, Byte ruedas, EVehiculos Marca)
        {
            this.marca = Marca;
            this.patente = patente;
            this.CantRuedas = ruedas;
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
