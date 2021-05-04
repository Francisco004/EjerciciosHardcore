using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        public static implicit operator string(Fabricante f)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("FABRICANTE: ");
            sb.AppendFormat($"{f.marca} - {f.pais}");

            return sb.ToString();
        }

        public static bool operator ==(Fabricante f1, Fabricante f2)
        {
            bool retorno = false;

            if (((object)f1) == null && ((object)f2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)f1) != null && ((object)f2) != null)
                {
                    if (f1.marca == f2.marca && f1.pais == f2.pais)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Fabricante f1, Fabricante f2)
        {
            return !(f1 == f2);
        }
    }
}