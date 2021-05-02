using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Futbol
{
    public class DirectorTecnico : Persona
    {
        public DirectorTecnico (string nombre, string apellido):base(nombre,apellido)
        {

        }

        protected override string FichaTecnica()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.NombreCompleto());

            return sb.ToString();
        }

        public override string ToString()
        {
            return FichaTecnica();
        }
    }
}
