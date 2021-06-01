using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class Medico : Personal
    {
        protected Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
        }

        public override string Info
        {
            get { return ToString(); }
        }

        public Medico (string apellido, int legajo, DateTime ingreso, Especialidad especialidad) : base(apellido,legajo,ingreso)
        {
            this.especialidad = especialidad;
        }

        protected override string ArmarInfo()
        {
            return "DOCTOR - " + base.ArmarInfo() + ", especialidad: " + this.especialidad;
        }

        public override string ToString()
        {
            return this.ArmarInfo() + " - Ingreso: " + this.Ingreso.ToLongTimeString();
        }
    }
}
