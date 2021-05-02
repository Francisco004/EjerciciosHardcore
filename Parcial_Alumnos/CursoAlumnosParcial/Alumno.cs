using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoAlumnosParcial
{
    public class Alumno : Persona
    {
        protected short anio;
        protected EDiviciones division;

        public string AnioDivision
        {
            get { return this.anio.ToString() + "º" + this.division.ToString(); }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, EDiviciones division): base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
            ValidarDocumentacion(documento);
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(AnioDivision);  

            return sb.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            int prueba1 = 0;
            int prueba2 = 0;
            bool retorno = false;

            for (int i = 0; i < doc.Length; i++)
            {
                if (i == 2 || i == 7)
                {
                    if (doc[i] == '-')
                    {
                        prueba1 = 1;
                    }
                    else
                    {
                        prueba1 = 0;
                        break;
                    }
                }
                else
                {
                    if ((doc[i] >= '0' && doc[i] <= '9'))
                    {
                        prueba2 = 1;
                    }
                    else
                    {
                        prueba2 = 0;
                        break;
                    }
                }
            }

            if (prueba1 == 1 && prueba2 == 1)
            {
                retorno = true;
                Documento = doc;
            }
            else
            {
               Documento = "Error en el  documento";
            }

            return retorno;
        }
    }
}
