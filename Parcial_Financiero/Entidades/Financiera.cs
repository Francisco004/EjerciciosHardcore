using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return listaDePrestamos; }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
        }

        public float InteresesEnDolares
        {   
            get { return CalcularInteresGanado(TipoDePrestamo.Dolares); } 
        }

        public float InteresesEnPesos
        {
            get { return CalcularInteresGanado(TipoDePrestamo.Pesos); }
        }

        public float InteresesTotales
        {
            get { return CalcularInteresGanado(TipoDePrestamo.Todos); }
        }
        
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public static implicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n\nRazon social: " + financiera.razonSocial);
            sb.AppendLine("Intereses totales: " + financiera.InteresesTotales);
            sb.AppendLine("Intereses por prestamos en dolares: " + financiera.InteresesEnDolares);
            sb.AppendLine("Intereses por prestamos en pesos: " + financiera.InteresesEnPesos);

            financiera.OrdenarPrestamos();

            foreach (Prestamo prueba in financiera.listaDePrestamos)
            {
                sb.AppendLine(prueba.Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarPrestamos()
        {
            foreach (Prestamo prueba in listaDePrestamos)
            {
                listaDePrestamos.Sort(prueba.OrdenarPorFecha);
            }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float total = 0;

            if(tipoPrestamo == TipoDePrestamo.Dolares || tipoPrestamo == TipoDePrestamo.Todos)
            {
                foreach (Prestamo dolares in listaDePrestamos)
                {
                   if(dolares is PrestamoDolares)
                    {
                        total = ((PrestamoDolares)dolares).Interes;
                    }
                }
            }
            else 
            {
                foreach (Prestamo pesos in listaDePrestamos)
                {
                    if (pesos is PrestamoPesos)
                    {
                        total = ((PrestamoPesos)pesos).Interes;
                    }
                }
            }

            return total;
        }

        public static bool operator ==(Financiera Lava, Prestamo Vehi)
        {
            bool retorno = false;

            if (((object)Lava) == null && ((object)Vehi) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)Lava) != null && ((object)Vehi) != null)
                {
                    foreach (Prestamo vehiculito in Lava.listaDePrestamos)
                    {
                        if (vehiculito == Vehi)
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera Lava, Prestamo Vehi)
        {
            if (Lava != Vehi)
            {
                Console.WriteLine("Se dio de alta el vehiculo...");
                Lava.listaDePrestamos.Add(Vehi);
            }

            return Lava;
        }
    }
}
