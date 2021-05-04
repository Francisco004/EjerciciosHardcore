using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public ECilindrada cilindrada;

        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada) : base(marca, pais, modelo, precio)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Moto m1, Moto m2)
        {
            bool retorno = false;

            if (((object)m1) == null && ((object)m2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)m1) != null && ((object)m2 != null))
                {
                    if ((Vehiculo)m1 == (Vehiculo)m2 && m1.cilindrada == m2.cilindrada)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Moto m1, Moto m2)
        {
            return !(m1 == m2);
        }

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }

        public override bool Equals(object obj)
        {
            return (Moto)obj == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{(string)(Vehiculo)this}");
            sb.AppendFormat($"CILINDRADA: {this.cilindrada}\n");

            return sb.ToString();
        }
    }
}