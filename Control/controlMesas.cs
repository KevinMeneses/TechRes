using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class controlMesas
    {
        Mesas mesas = new Mesas();
        public bool AgregarMesa(int id_res, int mesa, int sillas)
        {
            if (mesa != 0 && sillas != 0)
            {
                return mesas.AgregarMesa(id_res, mesa, sillas);
            }
            else
            {
                return false;
            }
        }

        public bool ModificarMesa(int id_mesa, int mesa, int sillas)
        {
            if (id_mesa != 0 && mesa != 0 && sillas != 0)
            {
                return mesas.ModificarMesa(id_mesa, mesa, sillas);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarMesas(int id_res)
        {
            return mesas.ConsultarMesas(id_res);
        }

        public DataSet BuscarMesa(int id_mesa, int id_res)
        {
            return mesas.BuscarMesa(id_mesa, id_res);
        }

        public bool EliminarMesa(int id_mesa)
        {
            return mesas.EliminarMesa(id_mesa);
        }
    }
}