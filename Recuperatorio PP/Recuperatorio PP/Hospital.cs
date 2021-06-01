using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class Hospital
    {
        private readonly string nombre;
        private readonly List<Personal> personal;

        public int CantidadPersonal
        {
            get { return personal.Count(); }
        }

        public Personal this[int indice]
        {
            get
            {
                if (indice == -1 && indice >= personal.Count)
                {
                    return null;
                }
                else
                {
                    return personal[indice];
                }
            }
        }

        private Hospital()
        {
            personal = new List<Personal>();
        }

        private Hospital(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static implicit operator Hospital(string nombre)
        {
            return new Hospital(nombre);
        }

        public static int operator |(Hospital h, Personal p)
        {
            int contador = 0;
            int retorno = -1;

            foreach (Personal personalito in h.personal)
            {
                if (p == personalito)
                {
                    retorno = contador;
                    break;
                }
                contador++;
            }

            return retorno;
        }

        public static Hospital operator +(Hospital h, Personal p)
        {
            int indice = h | p;

            if (indice == -1)
            {
                h.personal.Add(p);
            }

            return h;
        }

        public static Hospital operator -(Hospital h, Personal p)
        {
            int indice = h | p;

            if (indice != -1)
            {
                h.personal.RemoveAt(indice);
            }

            return h;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hospital " + this.nombre + "\nCantidad de pacientes: " + this.personal.Count + "\n\nListado de personas: ");

            foreach (Personal p in this.personal)
            {
                sb.AppendLine(p.ToString());
            }

            return sb.ToString();
        }
    }
}
