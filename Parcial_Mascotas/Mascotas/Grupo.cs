using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;

        public ETipoManada Tipo
        {
            set { tipo = value; }
        }

        private Grupo()
        {
            manada = new List<Mascota>();
        }

        static Grupo()
        {
            tipo = ETipoManada.Unica;
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            Tipo = tipo;
        }

        public static bool operator ==(Grupo grupito, Mascota mascotitas)
        {
            bool retorno = false;

            if (((object)grupito) == null && ((object)mascotitas) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)grupito) != null && ((object)mascotitas) != null)
                {
                    foreach (Mascota mascotita in grupito.manada)
                    {

                        if (mascotita == mascotitas && mascotita is Perro && mascotitas is Perro)
                        {
                            retorno = true;
                            break;
                        }
                        if (mascotita == mascotitas && mascotita is Gato && mascotitas is Gato)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }

            return retorno;
        }
        public static bool operator !=(Grupo grupito, Mascota mascotitas)
        {
            return !(grupito == mascotitas);
        }

        public static implicit operator string(Grupo grupito)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Grupo: " + grupito.nombre + " - tipo: " + Grupo.tipo);

            sb.AppendLine("Integrantes (" + grupito.manada.Count() + "):");

            foreach (Mascota mascotitas in grupito.manada)
            {
                sb.AppendLine(mascotitas.ToString());
            }
            return sb.ToString();
        }

        public static Grupo operator +(Grupo grupito, Mascota masctotita)
        {
            if (grupito != masctotita)
            {
                grupito.manada.Add(masctotita);
            }
            else
            {
                Console.WriteLine("Ya esta " + masctotita.ToString() + " en el grupo");
            }

            return grupito;
        }

        public static Grupo operator -(Grupo grupito, Mascota masctotita)
        {
            if (grupito == masctotita)
            {
                grupito.manada.Remove(masctotita);
            }
            else
            {
                Console.WriteLine("No esta " + masctotita.ToString() + " en el grupo");
            }

            return grupito;
        }
    }
}
