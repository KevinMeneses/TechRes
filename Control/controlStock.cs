using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class controlStock
    {
        Stock ing = new Stock();

        public bool AgregarIngrediente(int id_res, string ingrediente, int precio, int cantidad)
        {
            if (ingrediente != "" && precio != 0 && cantidad != 0)
            {
                return ing.AgregarIngrediente(id_res, ingrediente, precio, cantidad);
            }
            else
            {
                return false;
            }
        }

        public bool ModificarIngrediente(int id_ing, string ingrediente, int precio, int cantidad)
        {
            if (ingrediente != "" && precio != 0 && cantidad != 0)
            {
                return ing.ModificarIngrediente(id_ing, ingrediente, precio, cantidad);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarStock(int id_res)
        {
            return ing.ConsultarStock(id_res);
        }

        public DataSet BuscarIngrediente(int id_ing, int id_res)
        {
            return ing.BuscarIngrediente(id_ing, id_res);
        }

        public bool EliminarIngrediente(int id_ing)
        {
            return ing.EliminarIngrediente(id_ing);
        }
    }
}