using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre
        {
            get { return nombre; }
        }
        public string Raza
        {
            get { return raza; }
        }

        public Mascota(string nombre, string raza)
        {
            this.raza = raza;
            this.nombre = nombre;
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return this.nombre + " - " + this.raza;
        }

        public static bool operator ==(Mascota mascota1, Mascota mascota2)
        {
            bool retorno = false;

            if (((object)mascota1) == null && ((object)mascota2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)mascota1) != null && ((object)mascota2) != null)
                {
                    if (mascota1.nombre == mascota2.nombre && mascota1.raza == mascota2.raza)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Mascota mascota1, Mascota mascota2)
        {
            return !(mascota1 == mascota2);
        }
    }
}
