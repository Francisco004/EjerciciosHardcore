using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaParcial
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(int asientos, string patente, Byte ruedas, EMarcas marca) :base(patente, ruedas, marca)
        {
            this.cantidadAsientos = asientos;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Auto:  Cantidad de asientos: " + this.cantidadAsientos);
            sb.Append(base.Mostrar());

            return sb.ToString();
        }
    }
}
