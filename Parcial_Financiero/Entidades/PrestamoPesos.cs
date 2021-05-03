using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes):base (monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float interes) : base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        private float CalcularInteres()
        {
            return (float)Math.Round(this.monto * this.porcentajeInteres / 100);
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append("Porcenaje de interes: ");
            sb.AppendLine(this.porcentajeInteres.ToString());
            sb.Append("Interes: ");
            sb.AppendFormat(Interes.ToString());

            return sb.ToString();
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferencia;
            diferencia = nuevoVencimiento - this.Vencimiento;

            this.porcentajeInteres = this.porcentajeInteres + (float)(0.25 * (float)Convert.ToInt32(diferencia.Days));

            this.Vencimiento = nuevoVencimiento;
        }
    }
}

