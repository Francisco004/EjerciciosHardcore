using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private int valorHora;

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
            this.valorHora = 70;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            this.valorHora = valorHora;
        }

        public override string ImprimirTicket()
        {
            TimeSpan diferencia;
            diferencia = DateTime.Now - this.ingreso;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("PickUp: ");
            sb.AppendLine(base.ImprimirTicket());
            sb.Append("Costo de estadia: " + valorHora * Convert.ToInt32(diferencia.Hours));

            return sb.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("PickUp:");
            sb.AppendLine("Patente: " + Patente);
            sb.AppendLine("Modelo: " + this.modelo);
            sb.AppendLine("Valor por hora: " + valorHora);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is PickUp up)
            {
                rta = this == up;
            }

            return rta;
        }
    }
}
