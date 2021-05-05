using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        private int capacidad;
        private List<Producto> productos;

        public double PrecioDeCelulares
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeCelulares);
            }
        }

        public double PrecioDeTelevisores
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeTelevisores);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioTotal);
            }
        }

        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        private Deposito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Capacidad: {d.capacidad}\n");
            sb.AppendFormat($"Total de celulares: {d.PrecioDeCelulares}\n");
            sb.AppendFormat($"Total de televisores: {d.PrecioDeTelevisores}\n");
            sb.AppendFormat($"Total: {d.PrecioTotal}\n");

            sb.AppendLine("*********************************************");
            sb.AppendLine("Lista de Productos");
            sb.AppendLine("*********************************************");

            foreach (Producto item in d.productos)
            {
                sb.AppendFormat($"{item.ToString()}\n");
            }

            return sb.ToString();
        }

        private double ObtenerPrecio(EProducto tipoProducto)
        {
            double acumulador = 0;

            foreach (Producto item in this.productos)
            {
                switch (tipoProducto)
                {
                    case EProducto.PrecioDeCelulares:
                        if (item is Celular)
                        {
                            acumulador += (double)(Celular)item;
                        }
                        break;

                    case EProducto.PrecioDeTelevisores:
                        if (item is Televisor)
                        {
                            acumulador += (double)(Televisor)item;
                        }
                        break;

                    case EProducto.PrecioTotal:
                        if (item is Televisor)
                        {
                            acumulador += (double)(Televisor)item;
                        }
                        if (item is Celular)
                        {
                            acumulador += (double)(Celular)item;
                        }
                        break;
                }
            }

            return acumulador;
        }

        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            bool retorno = false;

            if (((object)d) == null && ((object)p) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)d) != null && ((object)p) != null)
                {
                    foreach (Producto x in d.productos)
                    {
                        if (x is Televisor && p is Televisor)
                        {
                            if ((Televisor)x == (Televisor)p)
                            {
                                return true;
                            }
                        }

                        if (x is Celular && p is Celular)
                        {
                            if ((Celular)x == (Celular)p)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }

            return retorno;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }


        public static Deposito operator +(Deposito d, Producto p)
        {
            if (d.capacidad > d.productos.Count)
            {
                if (d != p)
                {
                    d.productos.Add(p);
                }
                else
                {
                    Console.WriteLine("El producto ya se encuentra en el deposito!!!\n");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en el deposito!!!\n");
            }

            return d;
        }
    }
}
