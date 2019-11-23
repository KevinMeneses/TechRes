using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Empleados
    {
        Persistencia p = new Persistencia();

        public bool AgregarEmpleado(string id_emp, int id_res, string nombre, string apellido, string correo, string cargo, string contra)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.AgregarEmpleado";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_emp", OracleDbType.Varchar2, 20).Value = id_emp;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("nombre", OracleDbType.Varchar2, 40).Value = nombre;
            objSelectCmd.Parameters.Add("apellido", OracleDbType.Varchar2, 40).Value = apellido;
            objSelectCmd.Parameters.Add("correo", OracleDbType.Varchar2, 50).Value = correo;
            objSelectCmd.Parameters.Add("cargo", OracleDbType.Varchar2, 20).Value = cargo;
            objSelectCmd.Parameters.Add("contra", OracleDbType.Varchar2, 20).Value = contra;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[7].Value.ToString());
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

        public bool ModificarEmpleado(string id_viejo, string id_nuevo, string nombre, string apellido, string correo, string cargo, string contra)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ModificarEmpleado";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_viejo", OracleDbType.Varchar2, 20).Value = id_viejo;
            objSelectCmd.Parameters.Add("id_nuevo", OracleDbType.Varchar2, 20).Value = id_nuevo;
            objSelectCmd.Parameters.Add("e_nombre", OracleDbType.Varchar2, 40).Value = nombre;
            objSelectCmd.Parameters.Add("e_apellido", OracleDbType.Varchar2, 40).Value = apellido;
            objSelectCmd.Parameters.Add("e_correo", OracleDbType.Varchar2, 50).Value = correo;
            objSelectCmd.Parameters.Add("e_cargo", OracleDbType.Varchar2, 20).Value = cargo;
            objSelectCmd.Parameters.Add("e_contra", OracleDbType.Varchar2, 20).Value = contra;
            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).
                Direction = ParameterDirection.Output;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[7].Value.ToString());
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

        public DataSet ConsultarEmpleados(int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.ConsultarEmpleados";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorEmpleados", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public DataSet BuscarEmpleado(string id_emp, int id_res)
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.BuscarEmpleado";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("id", OracleDbType.Varchar2, 20).Value = id_emp;
            objSelectCmd.Parameters.Add("id_res", OracleDbType.Double).Value = id_res;
            objSelectCmd.Parameters.Add("cursorEmpleado", OracleDbType.RefCursor).
                Direction = ParameterDirection.Output;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();

            return datos;
        }

        public bool EliminarEmpleado(string id_emp)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRestaurante.EliminarEmpleado";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_emp", OracleDbType.Double).Value = id_emp;
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