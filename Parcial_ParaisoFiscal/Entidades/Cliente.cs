using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private readonly string _nombre;
        private readonly ETipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = ETipoCliente.SinTipo;
        }

        public Cliente(ETipoCliente tipoCliente) : this()
        {
            _tipoDeCliente = tipoCliente;
        }

        public Cliente(ETipoCliente tipoCliente, string nombre) : this(tipoCliente)
        { 
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            Random rand = new Random();

            int numeroRandom = rand.Next(1000, 9999);

            this._aliasParaIncognito = Convert.ToString(numeroRandom) + Convert.ToString(_tipoDeCliente);
        }

        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }

            return _aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Tipo : " + this._tipoDeCliente);
            sb.AppendFormat("Alias : " + this.GetAlias());
            

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }
    }
}
