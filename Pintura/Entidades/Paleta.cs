using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paleta
    {
        private readonly Tempera[] tempera;
        private readonly int cantidadMaximaColores;

        private Paleta()
        {
            this.cantidadMaximaColores = 5;
            this.tempera = new Tempera[this.cantidadMaximaColores];
        }

        private Paleta(int maximo):this()
        {
            this.cantidadMaximaColores = maximo;
        }

        public static implicit operator int(Paleta paleta)
        {
            int cantidad = 0;

            if (paleta != null)
            {
                cantidad = paleta.cantidadMaximaColores;
            }

            return cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tempera: " + this.tempera);
            sb.AppendLine("Cantidad maxima: " + this.cantidadMaximaColores);
            

            return sb.ToString(); 
        }
        
        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;

            if (((object)paleta) == null && ((object)tempera) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)paleta) != null && ((object)tempera) != null)
                {
                    for (int i = 0; i < paleta.cantidadMaximaColores; i++)
                    {
                        if (paleta.tempera[i] == tempera)
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta==tempera);
        }

        public int ObtenerIndice()
        {
            int retorno = ObtenerIndice(null);

            return retorno;
        }

        public int ObtenerIndice(Tempera tempera)
        {
            int retorno = -1;
            for (int i = 0; i < this.cantidadMaximaColores; i++)
            {
                if (this.tempera[i] == tempera)
                {
                    retorno = i;
                    break;
                }
            }
            
            return retorno;
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            if (paleta != null && tempera != null)
            {
                bool confirmacion = paleta == tempera;

                if (confirmacion)
                {
                    tempera += 1;
                }
                else
                {
                    paleta.tempera[paleta.ObtenerIndice()] = tempera;
                }
            }

            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            if (paleta != null && tempera != null)
            {
                bool confirmacion = paleta == tempera;
                
                if (confirmacion)
                {
                    tempera += -1;
                }
                else if(tempera < 0)
                {
                    paleta.tempera[paleta.ObtenerIndice(tempera)] = null; 
                }
            }

            return paleta;
        }

        public static Paleta operator +(Paleta paleta1, Paleta paleta2)
        {
            if (paleta1 != null && paleta2 != null)
            {
                Paleta nuevaPaleta = new Paleta(paleta1.cantidadMaximaColores + paleta2.cantidadMaximaColores);

                for (int i = 0; i < paleta1.cantidadMaximaColores; i++)
                {
                    for (int j = 0; j < paleta2.cantidadMaximaColores; j++)
                    {
                        if(paleta1.tempera[i] == paleta2.tempera[j])
                        {
                            nuevaPaleta.tempera[nuevaPaleta.ObtenerIndice(null)] = paleta1.tempera[i];
                            nuevaPaleta.tempera[nuevaPaleta.ObtenerIndice(null)] = paleta2.tempera[j];
                        }
                    }
                }  

                return nuevaPaleta;
            }

            return paleta1;
        }
    }
}
