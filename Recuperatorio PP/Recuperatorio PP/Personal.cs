using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public abstract class Personal
    {
        protected int legajo;
        protected string apellido;
        protected DateTime horarioEntrada;

        public string Apellido
        {
            get { return apellido; }
        }

        public abstract string Info
        {
            get;
        }

        public DateTime Ingreso
        {
            get { return horarioEntrada; }
        }

        public int Legajo
        {
            get { return legajo; }
        }

        public Personal(string apellido, int legajo, DateTime ingreso)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.horarioEntrada = ingreso;
        }

        public Personal(string apellido, int legajo) : this(apellido, legajo, DateTime.Now)
        {

        }

        protected virtual string ArmarInfo()
        {
            return this.apellido + ", " + "Legajo: " + this.legajo;
        }

        public override string ToString()
        {
            return ArmarInfo() + " - Ingreso:" + this.horarioEntrada.ToLongDateString();
        }

        public static explicit operator string(Personal p)
        {
            return p.legajo.ToString();
        }

        public static bool operator ==(Personal p1, Personal p2)
        {
            bool retorno = false;

            if (((object)p1) != null && ((object)p2) != null)
            {
                if(p1.legajo == p2.legajo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Personal p1, Personal p2)
        {
            return !(p1 == p2);
        }

        public static int OrdenarPorLegajoAsc(Personal p1, Personal p2)
        {
            return p1.legajo.CompareTo(p2.legajo);
        }

        public static int OrdenarPorLegajoDec(Personal p1, Personal p2)
        {
            int retorno = OrdenarPorLegajoAsc(p1,p2);

            return retorno * -1;
        }

        public static int OrdenarPorApellidoAsc(Personal p1, Personal p2)
        {
            return string.Compare(p1.apellido, p2.apellido);
        }

        public static int OrdenarPorApellidoDec(Personal p1, Personal p2)
        {
            int retorno = OrdenarPorApellidoAsc(p1, p2);

            return retorno * -1;
        }
    }
}
