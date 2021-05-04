using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private  int valorHora;

        public Moto(string patente,int cilindrada) : base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
            this.valorHora = 30;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente,cilindrada)
        {
            this.ruedas = ruedas;
            this.valorHora = 30;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            this.valorHora = valorHora;
        }

        public override string ImprimirTicket()
        {
            TimeSpan diferencia;
            diferencia = DateTime.Now - this.ingreso;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Moto: ");
            sb.AppendLine(base.ImprimirTicket());
            sb.Append("Costo de estadia: " + valorHora * Convert.ToInt32(diferencia.Hours));

            return sb.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Moto:");
            sb.AppendLine("Patente: " + Patente);
            sb.AppendLine("Cilindrada: " + this.cilindrada);
            sb.AppendLine("Ruedas: " + this.ruedas);
            sb.AppendLine("Valor por hora: " + valorHora);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Moto moto)
            {
                rta = this == moto;
            }

            return rta;
        }
    }
}
