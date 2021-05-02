using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza):base(nombre,raza)
        {

        }

        protected override string Ficha()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("gato - " + DatosCompletos());

            return retorno.ToString();
        }

        public override string ToString()
        {
            return Ficha();
        }

        public static bool operator ==(Gato gato1, Gato gato2)
        {
            return (Mascota)gato1 == (Mascota)gato2;
        }

        public static bool operator !=(Gato gato1, Gato perro2)
        {
            return !(gato1 == perro2);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Mascota)
            {
                rta = this == (Mascota)obj;
            }

            return rta;
        }
    }
}
