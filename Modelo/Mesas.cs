using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Mesas
    {
        Persistencia p = new Persistencia();
        public bool AgregarMesa(int id_res, int mesa, int sillas)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AgregarMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("mesa", OracleDbType.Double).Value = mesa;
            objSelectCmd.Parameters.Add("sillas", OracleDbType.Double).Value = sillas;
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

        public DataSet ConsultarMesas(int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ConsultarMesas";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorMesas", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public DataSet BuscarMesa(int id_mesa, int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.BuscarMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Varchar2, 20).Value = id_mesa;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorMesas", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public bool ModificarMesa(int id_mesa, int mesa, int sillas)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ModificarMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Double).Value = id_mesa;
            objSelectCmd.Parameters.Add("mesa", OracleDbType.Double).Value = mesa;
            objSelectCmd.Parameters.Add("sillas", OracleDbType.Double).Value = sillas;
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

        public bool EliminarMesa(int id_mesa)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.EliminarMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Double).Value = id_mesa;
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