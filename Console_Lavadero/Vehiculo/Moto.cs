using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaParcial
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(float cilindrada, string patente, Byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cilindrada: " + this.cilindrada);
            sb.AppendLine(Mostrar());

            return sb.ToString();
        }
    }
}
