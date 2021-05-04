using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
            this.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Automovil:");
            sb.AppendLine("Patente: " + Patente);
            sb.AppendLine("Color: " + color);
            sb.AppendLine("Valor por hora: " + valorHora);

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            TimeSpan diferencia;
            diferencia = DateTime.Now - this.ingreso;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Automovil: ");
            sb.AppendLine(base.ImprimirTicket());
            sb.Append("Costo de estadia " + valorHora * Convert.ToInt32(diferencia.Hours));

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Automovil automovil)
            {
                rta = this == automovil;
            }

            return rta;
        }
    }
}
