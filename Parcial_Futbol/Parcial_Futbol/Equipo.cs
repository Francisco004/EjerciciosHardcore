using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Futbol
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private DirectorTecnico dt;
        private static Deportes deporte;
        private string nombre;
        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby,
        }

        public Deportes Deporte
        {
            set { deporte = value; }
        }

        static Equipo()
        {
            Equipo.deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) :this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }
        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this()
        {
            this.nombre = nombre;
            this.dt = dt;
            this.Deporte = deporte;
        }

        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;

            if (((object)equipo) == null && ((object)jugador) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)equipo) != null && ((object)jugador) != null)
                {
                    foreach (Jugador jugadorsito in equipo.jugadores)
                    {
                        if (jugadorsito == jugador)
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }

        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo != jugador)
            {
                Console.WriteLine("Se dio de alta el jugador...");
                equipo.jugadores.Add(jugador);
            }

            return equipo;
        }

        public static Equipo operator -(Equipo equipo, Jugador jugador)
        {
            if (equipo == jugador)
            {
                Console.WriteLine("Se dio de baja el jugador...");
                equipo.jugadores.Remove(jugador);
            }

            return equipo;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*" + e.nombre + "*");
            sb.AppendLine("Nomina de jugadores:");

            foreach (Jugador jugadores in e.jugadores)
            {
                sb.AppendLine(jugadores.ToString());
            }
            sb.Append("Dirigido por: ");
            sb.AppendFormat(e.dt.ToString());

            return sb.ToString();
        }
    }
}
