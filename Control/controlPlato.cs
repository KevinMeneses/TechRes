using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class controlPlato
    {
        Platos platos = new Platos();

        public bool AgregarPlato(int id_res, string nombre, string descripcion, int precio)
        {
            if (nombre != "" && descripcion != "" && precio != 0)
            {
                return platos.AgregarPlato(id_res, nombre, descripcion, precio);
            }
            else
            {
                return false;
            }
        }

        public bool ModificarPlato(int id_plato, string nombre, string descripcion, int precio)
        {
            if (id_plato != 0 && nombre != "" && descripcion != "" && precio != 0)
            {
                return platos.ModificarPlato(id_plato, nombre, descripcion, precio);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarPlatos(int id_res)
        {
            return platos.ConsultarPlatos(id_res);
        }

        public DataSet BuscarPlato(int id_plato, int id_res)
        {
            return platos.BuscarPlato(id_plato, id_res);
        }

        public bool EliminarPlato(int id_plato)
        {
            return platos.EliminarPlato(id_plato);
        }
    }
}