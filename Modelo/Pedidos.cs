using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Pedidos
    {
        Persistencia p = new Persistencia();

        public DataSet ConsultarPedidos(int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ConsultarPedidos";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorPedidos", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public int AgregarPedido(int id_res, int id_mesa, string descripcion, int total)
        {
            int ejecuto = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AgregarPedido";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            if (id_mesa == 0)
            {
                objSelectCmd.Parameters.Add("p_id_mesa", OracleDbType.Double).Value = null;
            }
            else
            {
                objSelectCmd.Parameters.Add("p_id_mesa", OracleDbType.Double).Value = id_mesa;
            }
            objSelectCmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2, 300).Value = descripcion;
            objSelectCmd.Parameters.Add("p_total", OracleDbType.Double).Value = total;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                ejecuto = int.Parse(objSelectCmd.Parameters[4].Value.ToString());
            }
            catch (Exception e)
            {

            }
            p.cerrarConexion();
            return ejecuto;
        }

        public bool ModificarPedido(int id_pedido, int id_mesa, string descripcion, int total)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ModificarPedido";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_pedido", OracleDbType.Double).Value = id_pedido;
            if (id_mesa == 0)
            {
                objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Double).Value = null;
            }
            else
            {
                objSelectCmd.Parameters.Add("id_mesa", OracleDbType.Double).Value = id_mesa;
            }
            objSelectCmd.Parameters.Add("descripcion", OracleDbType.Varchar2, 300).Value = descripcion;
            objSelectCmd.Parameters.Add("total", OracleDbType.Double).Value = total;
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

        public DataSet BuscarPedido(int id_ped, int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.BuscarPedido";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_ped", OracleDbType.Double).Value = id_ped;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorPedidos", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public DataSet ConsultarPedidoMesa(int id_pedido)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ConsultarPedidoMesa";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_pedido", OracleDbType.Double).Value = id_pedido;
            objSelectCmd.Parameters.Add("cursorPedidoMesa", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public bool EliminarPedido(int id_ped)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.EliminarPedido";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_ped", OracleDbType.Double).Value = id_ped;
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

        public bool EliminarPlatosdelPedido(int id_pedido)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.EliminarPlatosdelPedido";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_pedido", OracleDbType.Double).Value = id_pedido;
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

        public bool AgregarPlatoPedido(int id_res, int id_pedido, int id_plato)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AgregarPlatoPedido";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("id_pedido", OracleDbType.Double).Value = id_pedido;
            objSelectCmd.Parameters.Add("id_plato", OracleDbType.Double).Value = id_plato;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[1].Value.ToString());
                if (filas > 0)
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