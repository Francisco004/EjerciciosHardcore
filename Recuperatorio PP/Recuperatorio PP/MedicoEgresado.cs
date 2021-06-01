using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class MedicoEgresado : Medico
    {
        protected DateTime horarioDeSalida;
        
        public DateTime Egreso
        {
            get { return horarioDeSalida; }
        }

        public override string Info
        {
            get { return ToString(); }
        }

        public double Jornal
        {
            get { return CalcularJornal(); }
        }

        public DateTime HorarioDeSalida
        {
            get { return horarioDeSalida; }
        }

        public MedicoEgresado(Medico medico) : base(medico.Apellido, medico.Legajo, medico.Ingreso, medico.Especialidad)
        {
            this.horarioDeSalida = DateTime.Now;
        }

        private double CalcularJornal()
        {
            double retorno = this - this;
            retorno = Math.Round(retorno);
            switch (this.Especialidad)
            {
                case Especialidad.Cirujano:
                    retorno *= 90;
                    break;
                case Especialidad.Clinico:
                    retorno *= 70;
                    break;
                case Especialidad.Pediatra:
                    retorno *= 40;
                    break;
            }
            return retorno;
        }

        public static double operator -(MedicoEgresado f1, MedicoEgresado f2)
        {
            TimeSpan diferencia = f2.Egreso - f1.Ingreso;

            return diferencia.TotalSeconds;
        }

        protected override string ArmarInfo()
        {
            return base.ArmarInfo() + " – JORNAL: " + this.Jornal;
        }

        public override string ToString()
        {
            return this.ArmarInfo() + " - Egreso: " + this.HorarioDeSalida.ToLongTimeString();
        }

        public static int OrdenarPorEspecialidad(MedicoEgresado p1, MedicoEgresado p2)
        {
            return string.Compare(p1.Especialidad.ToString(), p2.Especialidad.ToString());
        }

        public static int OrdenarPorJornalAsc(MedicoEgresado p1, MedicoEgresado p2)
        {
            return p1.Jornal.CompareTo(p2.Jornal);
        }

        public static int OrdenarPorJornalDec(MedicoEgresado p1, MedicoEgresado p2)
        {
            int retorno = OrdenarPorJornalAsc(p1, p2);

            return retorno * -1;
        }
        public static int OrdenarPorFechaEgresoAsc(MedicoEgresado p1, MedicoEgresado p2)
        {
            return p1.Egreso.CompareTo(p2.Egreso);
        }
        public static int OrdenarPorFechaEgresoDec(MedicoEgresado p1, MedicoEgresado p2)
        {
            int retorno = OrdenarPorFechaEgresoAsc(p1, p2);

            return retorno * -1;
        }
    }
}
