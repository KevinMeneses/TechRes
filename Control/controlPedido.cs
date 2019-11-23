using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class controlPedido
    {
        Pedidos ped = new Pedidos(); 

        public int AgregarPedido(int id_res, int id_mesa, string descripcion, int total)
        {
            if (total != 0)
            {
                return ped.AgregarPedido(id_res, id_mesa, descripcion, total);
            }
            else
            {
                return 0;
            }
        }

        public bool ModificarPedido(int id_pedido, int id_mesa, string descripcion, int total)
        {
            if (total != 0)
            {
                return ped.ModificarPedido(id_pedido, id_mesa, descripcion, total);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarPedidos(int id_res)
        {
            return ped.ConsultarPedidos(id_res);
        }

        public DataSet BuscarPedido(int id_ped, int id_res)
        {
            return ped.BuscarPedido(id_ped, id_res);
        }

        public DataSet ConsultarPedidoMesa(int id_pedido)
        {
            return ped.ConsultarPedidoMesa(id_pedido);
        }

        public bool EliminarPedido(int id_emp)
        {
            return ped.EliminarPedido(id_emp);
        }

        public bool EliminarPlatosdelPedido(int id_pedido)
        {
            return ped.EliminarPlatosdelPedido(id_pedido);
        }

        public bool AgregarPlatoPedido(int id_res, int id_pedido, int id_plato)
        {
            return ped.AgregarPlatoPedido(id_res, id_pedido, id_plato);
        }
    }
}