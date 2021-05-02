using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoAlumnosParcial
{
    public class Profesor : Persona
    {
        protected DateTime fechaIngreso;

        public int Antiguedad
        {   
            get
            {
                TimeSpan diferencia;
                diferencia = DateTime.Now - fechaIngreso;
                return diferencia.Days; 
            }
        }

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento){}

        public Profesor(string nombre, string apellido, string documento, DateTime fecha) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fecha;
            ValidarDocumentacion(documento);
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("Dias de antiguedad " + this.Antiguedad);

            return sb.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            if (doc.Length == 8)
            {
                Documento = doc;
                retorno = true;
            }
            else
            {
                Documento = "Error en el  documento";
            }

            return retorno;
        }
    }
}
