using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class controlEmpleado
    {
        Empleados emp = new Empleados();

        public bool AgregarEmpleado(string id_emp, int id_res, string nombre, string apellido, string correo, string cargo, string contra)
        {
            if (id_emp != "" && id_res != 0 && nombre != "" && apellido != "" && correo != "" && cargo != "" && contra != "")
            {
                return emp.AgregarEmpleado(id_emp, id_res, nombre, apellido, correo, cargo, contra);
            }
            else
            {
                return false;
            }
        }

        public bool ModificarEmpleado(string id_viejo, string id_nuevo, string nombre, string apellido, string correo, string cargo, string contra)
        {
            if (id_viejo != "" && id_nuevo != "" && nombre != "" && apellido != "" && correo != "" && cargo != "" && contra != "")
            {
                return emp.ModificarEmpleado(id_viejo, id_nuevo, nombre, apellido, correo, cargo, contra);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarEmpleados(int id_res)
        {
            return emp.ConsultarEmpleados(id_res);
        }

        public DataSet BuscarEmpleado(string id_emp, int id_res)
        {
            return emp.BuscarEmpleado(id_emp, id_res);
        }

        public bool EliminarEmpleado(string id_emp)
        {
            return emp.EliminarEmpleado(id_emp);
        }
    }
}