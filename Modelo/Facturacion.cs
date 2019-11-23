using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Facturacion
    {
        Persistencia p = new Persistencia();

        public bool AsignarEmpleadoaMesa(int id_mesa, string id_emp)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AsignarEmpleadoaMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Double).Value = id_mesa;
            objSelectCmd.Parameters.Add("id_emp", OracleDbType.Varchar2, 20).Value = id_emp;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[2].Value.ToString());
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

        public bool QuitarEmpleadodeMesa(int id_mesa)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.QuitarEmpleadodeMesa";
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

        public bool AsignarPedidoaMesa(int id_mesa, int id_pedido)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AsignarPedidoaMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Double).Value = id_mesa;
            objSelectCmd.Parameters.Add("id_pedido", OracleDbType.Double).Value = id_pedido;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[2].Value.ToString());
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

        public bool QuitarPedidodeMesa(int id_mesa)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.QuitarPedidodeMesa";
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