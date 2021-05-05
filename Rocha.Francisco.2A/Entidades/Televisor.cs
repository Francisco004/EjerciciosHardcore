using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Televisor : Producto
    {
        public ETipo tipo;

        public Televisor(string modelo, string marca, EPais pais, ETipo tipo) : base(modelo,marca,pais)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Televisor a, Televisor b)
        {
            bool retorno = false;

            if (((object)a) == null && ((object)b) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)a) != null && ((object)b) != null)
                {
                    if ((Producto)a == (Producto)b && a.tipo == b.tipo)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }

        public static explicit operator double(Televisor tv)
        {
            return tv.Precio;
        }

        public override bool Equals(object obj)
        {
            return ((Televisor)obj) == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{(string)(Producto)this}");
            sb.AppendFormat($"TIPO: {this.tipo}\n");

            return sb.ToString();
        }
    }
}
