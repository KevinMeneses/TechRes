using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Platos
    {
        Persistencia p = new Persistencia();

        public bool AgregarPlato(int id_res, string nombre, string descripcion, int precio)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AgregarPlato";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("nombre", OracleDbType.Varchar2, 60).Value = nombre;
            objSelectCmd.Parameters.Add("descripcion", OracleDbType.Varchar2, 100).Value = descripcion;
            objSelectCmd.Parameters.Add("precio", OracleDbType.Double).Value = precio;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[4].Value.ToString());
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

        public DataSet ConsultarPlatos(int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ConsultarPlatos";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorPlatos", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public DataSet BuscarPlato(int id_plato, int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.BuscarPlato";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_plato", OracleDbType.Varchar2, 20).Value = id_plato;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorMesas", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public bool ModificarPlato(int id_plato, string nombre, string descripcion, int precio)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ModificarPlato";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_plato", OracleDbType.Double).Value = id_plato;
            objSelectCmd.Parameters.Add("nombre", OracleDbType.Varchar2, 60).Value = nombre;
            objSelectCmd.Parameters.Add("descripcion", OracleDbType.Varchar2, 100).Value = descripcion;
            objSelectCmd.Parameters.Add("precio", OracleDbType.Double).Value = precio;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[4].Value.ToString());
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

        public bool EliminarPlato(int id_plato)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.EliminarPlato";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_plato", OracleDbType.Double).Value = id_plato;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[1].Value.ToString());
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