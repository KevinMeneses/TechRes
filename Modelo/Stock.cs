using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Stock
    {
        Persistencia p = new Persistencia();

        public bool AgregarIngrediente(int id_res, string ingrediente, int precio, int cantidad)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AgregarIngrediente";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("ingrediente", OracleDbType.Varchar2, 60).Value = ingrediente;
            objSelectCmd.Parameters.Add("precio", OracleDbType.Double).Value = precio;
            objSelectCmd.Parameters.Add("cantidad", OracleDbType.Double).Value = cantidad;
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

        public DataSet ConsultarStock(int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ConsultarStock";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorStock", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public DataSet BuscarIngrediente(int id_ing, int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.BuscarIngrediente";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_ing", OracleDbType.Double).Value = id_ing;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorIngrediente", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public bool ModificarIngrediente(int id_ing, string ingrediente, int precio, int cantidad)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ModificarIngrediente";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_ing", OracleDbType.Double).Value = id_ing;
            objSelectCmd.Parameters.Add("ingrediente", OracleDbType.Varchar2, 40).Value = ingrediente;
            objSelectCmd.Parameters.Add("precio", OracleDbType.Double).Value = precio;
            objSelectCmd.Parameters.Add("cantidad", OracleDbType.Double).Value = cantidad;
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

        public bool EliminarIngrediente(int id_ing)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.EliminarIngrediente";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_ing", OracleDbType.Double).Value = id_ing;
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