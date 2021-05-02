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
            this.vencimiento = vencimiento;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Monto: " + this.monto);
            sb.AppendLine("Vencimiento: " + this.vencimiento);

            return sb.ToString();
        }

        public int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return string.Compare(p1.vencimiento.ToString(), p2.vencimiento.ToString());
        }
    }
}
