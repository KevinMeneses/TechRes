using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class controlFacturacion
    {
        Facturacion fac = new Facturacion();        

        public bool AsignarPedidoaMesa(int id_mesa, int id_pedido)
        {
            return fac.AsignarPedidoaMesa(id_mesa, id_pedido);
        }

        public bool LiberarMesa(int id, int id_res)
        {
            return true;
        }

        public bool AsignarEmpleadoaMesa(int id_mesa, string id_emp)
        {
            return fac.AsignarEmpleadoaMesa(id_mesa, id_emp);
        }

        public bool QuitarEmpleadodeMesa(int id_mesa)
        {
            return fac.QuitarEmpleadodeMesa(id_mesa);
        }

        public bool QuitarPedidodeMesa(int id_mesa)
        {
            return fac.QuitarPedidodeMesa(id_mesa);
        }
    }
}