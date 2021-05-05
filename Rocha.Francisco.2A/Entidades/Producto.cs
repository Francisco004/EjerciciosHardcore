using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorDePreciosRandom;
        protected string modelo;
        protected double precio;

        public double Precio
        {
            get
            {
                if (this.precio == 0)
                {
                    this.precio = Producto.generadorDePreciosRandom.Next(10500, 125000);
                }
                return this.precio;
            }
        }

        static Producto()
        {
            Producto.generadorDePreciosRandom = new Random();
        }

        public Producto(string modelo, Fabricante fabricante)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.precio = this.Precio;
        }

        public Producto(string modelo, string marca, EPais pais) : this(modelo, new Fabricante(marca, pais))
        {

        }

        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{(string)p.fabricante}\n");
            sb.AppendFormat($"MODELO: {p.modelo}\n");
            sb.AppendFormat($"PRECIO: {p.precio}\n");

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (((object)p1) == null && ((object)p2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)p1) != null && ((object)p2) != null)
                {
                    if ((p1.modelo == p2.modelo && p1.fabricante == p2.fabricante))
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator string(Producto p)
        {
            return Producto.Mostrar(p);
        }
    }
}
