using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaOffShore
    {
        private readonly Cliente _duenio;
        private readonly int _numeroCuenta;
        private double _saldo;

        public Cliente Dueño
        {
            get { return this._duenio; }
        }
       
        public double Sueldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }

        public CuentaOffShore(Cliente duenio, int numero, double saldoInicial)
        {
           this._duenio = duenio;
           this._numeroCuenta = numero;
           this._saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, ETipoCliente tipo, int numero, double saldoInicial) : this(new Cliente(tipo, nombre), numero, saldoInicial)
        {
            
        }

        public static explicit operator int(CuentaOffShore cos)
        {
            int numeroCuentas = 0;

            if (cos != null)
            {
                numeroCuentas = cos._numeroCuenta;
            }

            return numeroCuentas;
        }

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;

            if (((object)cos1) == null && ((object)cos2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)cos1) != null && ((object)cos2) != null)
                {
                    if (cos1._numeroCuenta == cos2._numeroCuenta && cos1._duenio.GetAlias() == cos2._duenio.GetAlias())
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
    }
}
