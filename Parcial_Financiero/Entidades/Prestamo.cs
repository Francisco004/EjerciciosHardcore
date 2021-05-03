using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get { return this.monto; }
        }

        public DateTime Vencimiento
        {
            get { return this.vencimiento; }
            set 
            { if (value > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nMonto: " + this.monto);
            sb.Append("Vencimiento: " + this.vencimiento);

            return sb.ToString();
        }

        public int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno;

            if(p1.Vencimiento > p2.Vencimiento)
            {
                retorno = 1;
            }
            else if (p1.Vencimiento < p2.Vencimiento)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }
    }
}
