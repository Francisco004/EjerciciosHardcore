using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get { return patente; }
            set 
            {
                if (value.Length == 6)
                {
                    patente = value;
                }
                else patente = null;
            }
        }

        public Vehiculo (string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return ("Patente " + this.Patente).ToString();
        }
            
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ToString());
            sb.Append("Fecha y hora de ingreso " + this.ingreso);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo vehi1, Vehiculo vehi2)
        {
            bool retorno = false;

            if (((object)vehi1) == null && ((object)vehi2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)vehi1) != null && ((object)vehi2) != null)
                {
                    if(vehi1.patente == vehi2.patente && (object)vehi1 == (object)vehi2)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo vehi1, Vehiculo vehi2)
        {
            return !(vehi1 == vehi2);
        }
    }

}
