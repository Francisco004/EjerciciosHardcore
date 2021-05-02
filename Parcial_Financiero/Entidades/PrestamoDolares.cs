using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolares : Prestamo
    {
        private readonly PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get { return periodicidad; }
        }

        public PrestamoDolares(float monto, DateTime vencimiento, PeriodicidadDePagos periodiciad): base(monto, vencimiento)
        {
            this.periodicidad = periodiciad;
        }
        public PrestamoDolares(Prestamo prestamo, PeriodicidadDePagos periodiciad) : base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.periodicidad = periodiciad;
        }

        private float CalcularInteres()
        {
            float resultado;

            if(this.periodicidad == PeriodicidadDePagos.Mensual)
            {
                resultado = (float)Math.Round(this.monto * 25 / 100);
            }
            else if (this.periodicidad == PeriodicidadDePagos.Bimestral)
            {
                resultado = (float)Math.Round(this.monto * 35 / 100);
            }
            else
            {
                resultado = (float)Math.Round(this.monto * 45 / 100);
            }

            return resultado;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Periodicidad: ");
            sb.AppendLine(this.periodicidad.ToString());
            sb.AppendLine(" Interes: ");
            sb.AppendFormat(Interes.ToString());

            return sb.ToString();
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferencia;
            diferencia = nuevoVencimiento - this.Vencimiento;

            this.monto = (float)(2.5 * (float)Convert.ToInt32(diferencia));

            this.Vencimiento = nuevoVencimiento;
        }
    }
}
