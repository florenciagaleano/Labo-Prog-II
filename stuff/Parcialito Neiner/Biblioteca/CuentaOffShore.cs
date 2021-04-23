using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public CuentaOffShore(Cliente dueño, int numeroCuenta, double saldoInicial)
            :this(dueño._nombre,dueño._tipoDeCliente,numeroCuenta,saldoInicial)
        {

        }

        public CuentaOffShore(string nombre,Cliente.eTipoCliente tipo, int numeroCuenta, double saldoInicial)
        {
            this._dueño = new Cliente(tipo, nombre);
            this._saldo = saldoInicial;
            this._numeroCuenta = numeroCuenta;
        }

        public Cliente Dueño
        {
            get
            {
                return this._dueño;
            }
        }

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                this._saldo = value;
            }
        }

        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

        public static bool operator ==(CuentaOffShore cos1,CuentaOffShore cos2)
        {
            if(cos1._numeroCuenta == cos2._numeroCuenta && cos1._dueño == cos2._dueño)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }



    }
}
