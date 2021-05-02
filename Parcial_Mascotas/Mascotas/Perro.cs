using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Perro : Mascota
    {
        private int edad;
        private bool EsAlfa;

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.EsAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre,raza)
        {
            this.edad = edad;
            this.EsAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Perro - " + DatosCompletos());

            if (this.EsAlfa == true)
            {
                sb.Append(" Alfa de la manada");
            }

            sb.Append(", edad " + this.edad);

            return sb.ToString();
        }

        public override string ToString()
        {
            return Ficha();
        }

        public static bool operator ==(Perro perro1, Perro perro2)
        {
            return ((Mascota)perro1 == (Mascota)perro2 && (perro1.edad == perro2.edad));
        }

        public static bool operator !=(Perro perro1, Perro perro2)
        {
            return !(perro1 == perro2);
        }

        public static explicit operator int(Perro perrito)
        {
            int edadPerro = 0;

            if (perrito != null)
            {
                edadPerro = perrito.edad;
            }

            return edadPerro;
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
