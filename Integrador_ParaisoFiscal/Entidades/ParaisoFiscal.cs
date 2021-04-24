using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class ParaisoFiscal
    {
        private readonly List<CuentaOffShore> listadoCuentas;
        private readonly EParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        private ParaisoFiscal()
        {
            listadoCuentas = new List<CuentaOffShore>();
        }

        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal(EParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nFecha inicio de actividades:" + fechaInicioActividades);
            sb.AppendLine("Lugar de radicacion:" + this._lugar);
            sb.AppendLine("Cantidad de 'cuentitas':" + cantidadDeCuentas);

            sb.AppendLine("********************Listado de cuentas offshores********************");

            foreach (CuentaOffShore cuentita in listadoCuentas)
            {
                sb.AppendLine(Cliente.RetornarDatos(cuentita.Dueño));
                sb.AppendLine("Numero de cuenta: " + (int)cuentita);
                sb.AppendLine("Sueldo: " + cuentita.Sueldo.ToString());
                sb.AppendFormat("\n");
            }

            sb.ToString();

            Console.Write(sb);
        }

        public static implicit operator ParaisoFiscal(EParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }

        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            if (((object)pf) == null && ((object)cos) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)pf) != null && ((object)cos) != null)
                {
                    for (int i = 0; i < cantidadDeCuentas; i++)
                    {
                        if (pf.listadoCuentas[i] == cos)
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
                if(pf == cos)
                {
                    pf.listadoCuentas.Remove(cos);
                    cantidadDeCuentas -= 1;
                    Console.WriteLine("Se quito la cuenta del paraiso...");
                }
                else
                {
                    Console.WriteLine("La cuenta no se encuentra en el paraiso...");
                }

            return pf;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf != cos)
            {
                pf.listadoCuentas.Add(cos);

                cantidadDeCuentas++;

                Console.WriteLine("Se agrego la cuenta al paraiso...");
            }
            else
            {
                foreach (CuentaOffShore cuentita in pf.listadoCuentas)
                {
                    if(cuentita.Dueño == cos.Dueño)
                    {
                        cuentita.Sueldo += cos.Sueldo;
                    }
                }
                Console.WriteLine("Se actualizo el saldo de la cuenta...");
            }

            return pf;
        }
    }
}
