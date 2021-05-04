
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {

        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        public int VelocidadMaxima
        {
            get
            {
                if (this.velocidadMaxima == 0)
                {
                    this.velocidadMaxima = Vehiculo.generadorDeVelocidades.Next(100, 280);
                }
                return this.velocidadMaxima;
            }
        }

        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidades = new Random();
        }

        public Vehiculo(float precio, string modelo, Fabricante fabricante)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.velocidadMaxima = this.VelocidadMaxima;
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio) : this(precio, modelo, new Fabricante(marca, pais))
        {

        }

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{(string)v.fabricante}\n");
            sb.AppendFormat($"MODELO: {v.modelo}\n");
            sb.AppendFormat($"VELOCIDAD MAXIMA: {v.velocidadMaxima}\n");
            sb.AppendFormat($"PRECIO: {v.precio}\n");

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (((object)v1) == null && ((object)v2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)v1) != null && ((object)v2) != null)
                {
                    if ((v1.modelo == v2.modelo && v1.fabricante == v2.fabricante))
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public static explicit operator string(Vehiculo v)
        {
            return Vehiculo.Mostrar(v);
        }

    }
}