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

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Cantidad de asientos: " + this.cantidadAsientos);
            sb.Append(Mostrar());

            return sb.ToString();
        }
    }
}
