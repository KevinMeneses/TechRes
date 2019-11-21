using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Persistencia
    {
        OracleConnection cadena = new OracleConnection(
            ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);

        public OracleConnection abrirConexion()
        {
            cadena.Open();
            return cadena;
        }

        public void cerrarConexion()
        {
            cadena.Close();
        }
    }
}