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

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Moto:  Cilindrada: " + this.cilindrada);
            sb.Append(base.Mostrar());

            return sb.ToString();
        }
    }
}
