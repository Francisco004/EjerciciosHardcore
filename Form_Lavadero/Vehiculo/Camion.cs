﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaParcial
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(float tara, string patente, Byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Tara: " + this.tara);
            sb.Append(Mostrar());

            return sb.ToString();
        }
    }
}
    