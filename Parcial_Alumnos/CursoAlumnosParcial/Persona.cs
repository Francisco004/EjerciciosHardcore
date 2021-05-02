using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoAlumnosParcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string documento;
        protected string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Documento
        {
            get { return this.documento; }
            set 
            {    
               this.documento = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendFormat("Documento: " + this.documento);

            return sb.ToString();
        }

        public abstract bool ValidarDocumentacion(string doc);
    }
}
