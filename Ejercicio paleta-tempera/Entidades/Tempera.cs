using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tempera
    {
        private readonly ConsoleColor color;
        private readonly string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Color: " + this.color);
            sb.AppendLine("Marca: " + this.marca);
            sb.AppendFormat("Cantidad: " + this.cantidad);

            return sb.ToString(); ;
        }
        
        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool retorno = false;

            if(((object)tempera1) == null && ((object)tempera2) == null)
            {
                retorno = true;
            }
            else
            {
                if(((object)tempera1) != null && ((object)tempera2) != null)
                {
                    if(tempera1.marca == tempera2.marca && tempera1.color == tempera2.color)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static implicit operator int(Tempera tempera)
        {
            int cantidad = 0;

            if (tempera != null)
            {
                cantidad = tempera.cantidad;
            }
            
            return cantidad;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if(tempera1 != null && tempera2 != null)
            {
                if(tempera1 == tempera2)
                {
                    tempera1.cantidad += tempera2;
                }
            }

            return tempera1;
        }
        
        public static Tempera operator +(Tempera tempera1, int cantidadSumar)
        {
            if (tempera1 != null)
            {
                tempera1.cantidad += cantidadSumar;
            }

            return tempera1;
        }

    }
}
