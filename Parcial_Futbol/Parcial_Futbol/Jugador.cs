using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Futbol
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan
        {
            get { return esCapitan; }
            set { esCapitan = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Jugador(string nombre, string apellido) : base(nombre, apellido)
        {
            this.numero = 0;
            this.esCapitan = false;
        }

        public Jugador(string nombre, string apellido, int numero, bool esCapitan): this(nombre,apellido)
        {
            this.numero = numero;
            this.esCapitan = esCapitan;
        }

        protected override string FichaTecnica()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.NombreCompleto());
            if (this.esCapitan == true)
            {
                sb.AppendLine(", Capitan del equipo");
            }
            sb.AppendLine(", Camiseta numero " + numero);

            return sb.ToString();
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;

            if (((object)jugador1) == null && ((object)jugador2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)jugador1) != null && ((object)jugador2) != null)
                {
                    if (jugador1.Nombre == jugador2.Nombre && jugador1.Apellido == jugador2.Apellido && jugador1.numero == jugador2.numero)
                    { 
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }

        public static explicit operator int(Jugador c)
        {
            return c.numero;
        }

        public override string ToString()
        {
            return FichaTecnica();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Jugador)
            {
                rta = this == (Jugador)obj;
            }

            return rta;
        }
    }
}
