using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoAlumnosParcial
{
    public class Curso
    {
        private List<Persona> personas;
        private short anio;
        private EDiviciones division;
        private Profesor profesor;

        private Curso()
        {
            personas = new List<Persona>();
        }

        public Curso(short anio, EDiviciones division, Profesor profe) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profe;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Año: " + c.anio);
            sb.AppendLine("Division " + c.division);
            sb.AppendLine("Profesor \n" + c.profesor.ExponerDatos());

            foreach (Alumno alumnitos in c.personas)
            {
                sb.AppendLine(alumnitos.ExponerDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Curso cursito, Alumno alumnito)
        {
            bool retorno = false;

            if (((object)cursito) == null && ((object)alumnito) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)cursito) != null && ((object)alumnito) != null)
                {
                    if (cursito.anio.ToString() + "º" + cursito.division.ToString() == alumnito.AnioDivision)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Curso cursito, Alumno alumnito)
        {
            return !(cursito == alumnito);
        }

        public static Curso operator +(Curso cursito, Alumno alumnito)
        {
            if (cursito == alumnito)
            {
                cursito.personas.Add(alumnito);
            }

            return cursito;
        }
    }
}
