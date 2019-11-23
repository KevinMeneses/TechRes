using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class TechRes
    {
        Persistencia p = new Persistencia();

        public int IniciarSesion(string correo, string contra)
        {
            int ejecuto = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.IniciarSesion";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("correo", OracleDbType.Varchar2, 50).Value = correo;
            objSelectCmd.Parameters.Add("contra", OracleDbType.Varchar2, 20).Value = contra;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                ejecuto = int.Parse(objSelectCmd.Parameters[2].Value.ToString());
            }
            catch (Exception e)
            {

            }
            p.cerrarConexion();
            return ejecuto;
        }

        public bool Registrarse(string nombre, string correo, string contra)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.Registrarse";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("nombre", OracleDbType.Varchar2, 40).Value = nombre;
            objSelectCmd.Parameters.Add("correo", OracleDbType.Varchar2, 50).Value = correo;
            objSelectCmd.Parameters.Add("contra", OracleDbType.Varchar2, 20).Value = contra;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[3].Value.ToString());
                if (filas == 1)
                {
                    ejecuto = true;
                }
            }
            catch (Exception e)
            {

            }
            p.cerrarConexion();
            return ejecuto;
        }
    }
}