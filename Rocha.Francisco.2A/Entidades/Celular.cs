using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular : Producto
    {
        public EGama gama;

        public Celular(string modelo, Fabricante fabricante, EGama gama) : base(modelo, fabricante)
        {
            this.gama = gama;
        }

        public static bool operator ==(Celular a, Celular b)
        {
            bool retorno = false;

            if (((object)a) == null && ((object)b) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)a) != null && ((object)b != null))
                {
                    if ((Producto)a == (Producto)b && a.gama == b.gama)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        public static implicit operator double(Celular celu)
        {
            return celu.precio;
        }

        public override bool Equals(object obj)
        {
            return (Celular)obj == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{(string)(Producto)this}");
            sb.AppendFormat($"Gama: {this.gama}\n");

            return sb.ToString();
        }
    }
}
