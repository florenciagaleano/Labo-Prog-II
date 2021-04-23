using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        public enum eTipoCliente{
            PoliticoCorrupto, EmpresarioCorrupto, JugadorDeFutbol, Financista, SinTipo,
        }

        private string _aliasParaIncognito;
        public string _nombre;//ya se que esta mal :(
        public eTipoCliente _tipoDeCliente;

        #region Constructores

        private Cliente()
            :this(eTipoCliente.SinTipo, "NN")
        {
            //this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            //this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente)
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente,string nombre)
            :this(tipoCliente)
        {
            this._nombre = nombre;
        }

        #endregion

        #region Metodos

        private void CrearAlias()
        {
            Random rnd = new Random();
            int numAlias = rnd.Next(1000, 9999);
            this._aliasParaIncognito = numAlias.ToString() + this._tipoDeCliente;
        }

        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this._aliasParaIncognito);
            sb.AppendLine(this._nombre);
            sb.AppendLine((this._tipoDeCliente).ToString());

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente uncliente)
        {
            return uncliente.RetornarDatos();
        }

        #endregion
    }
}
