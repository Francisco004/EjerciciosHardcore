using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Futbol
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return String.Format("{0} {1}", this.nombre, this.apellido);
        }
    }
}
