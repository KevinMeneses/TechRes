using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control {

    public class controlRes
    {
        TECHRES TR = new TECHRES();
        public int IniciarSesion(string correo, string contra)
        {
            if (correo != "" && contra != "")
            {
                return TR.IniciarSesion(correo, contra);
            }
            else
            {
                return 0;
            }
        }

        public int ObtenerResId(string correo)
        {
            if (correo != "")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public bool Registrarse(string nombre, string correo, string contra)
        {
            if (nombre != "" && correo != "" && contra != "")
            {
                return TR.Registrarse(nombre, correo, contra);
            }
            else
            {
                return false;
            }
        }

        public bool AgregarEmpleado(string id_emp, int id_res, string nombre, string apellido, string correo, string cargo, string contra)
        {
            if (id_emp != "" && id_res != 0 && nombre != "" && apellido != "" && correo != "" && cargo != "" && contra != "")
            {
                return TR.AgregarEmpleado(id_emp, id_res, nombre, apellido, correo, cargo, contra);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarPedidoMesa(int id_pedido)
        {
            return TR.ConsultarPedidoMesa(id_pedido);
        }

        public bool ModificarEmpleado(string id_viejo, string id_nuevo, string nombre, string apellido, string correo, string cargo, string contra)
        {
            if (id_viejo != "" && id_nuevo != "" && nombre != "" && apellido != "" && correo != "" && cargo != "" && contra != "")
            {
                return TR.ModificarEmpleado(id_viejo, id_nuevo, nombre, apellido, correo, cargo, contra);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarEmpleados(int id_res)
        {
            return TR.ConsultarEmpleados(id_res);
        }

        public DataSet BuscarEmpleado(string id_emp, int id_res)
        {
            return TR.BuscarEmpleado(id_emp, id_res);
        }

        public bool EliminarEmpleado(string id_emp)
        {
            return TR.EliminarEmpleado(id_emp);
        }

        public int AgregarPedido(int id_res, int id_mesa, string descripcion, int total)
        {
            if (total != 0)
            {
                return TR.AgregarPedido(id_res, id_mesa, descripcion, total);
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
                return TR.ModificarPedido(id_pedido, id_mesa, descripcion, total);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarPedidos(int id_res)
        {
            return TR.ConsultarPedidos(id_res);
        }

        public DataSet BuscarPedido(int id_ped, int id_res)
        {
            return TR.BuscarPedido(id_ped, id_res);
        }

        public bool EliminarPedido(int id_emp)
        {
            return TR.EliminarPedido(id_emp);
        }

        public bool AgregarMesa(int id_res, int mesa, int sillas)
        {
            if (mesa != 0 && sillas != 0)
            {
                return TR.AgregarMesa(id_res, mesa, sillas);
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
                return TR.ModificarMesa(id_mesa, mesa, sillas);
            }
            else
            {
                return false;
            }
        }

        public bool EliminarPlatosdelPedido(int id_pedido)
        {
            return TR.EliminarPlatosdelPedido(id_pedido);
        }

        public bool AsignarPedidoaMesa(int id_mesa, int id_pedido)
        {
            return TR.AsignarPedidoaMesa(id_mesa, id_pedido);
        }

        public bool AgregarPlatoPedido(int id_res, int id_pedido, int id_plato)
        {
            return TR.AgregarPlatoPedido(id_res, id_pedido, id_plato);
        }

        public DataSet CargarComboMesas(int id_res)
        {
            return new DataSet();
        }

        public DataSet ConsultarMesas(int id_res)
        {
            return TR.ConsultarMesas(id_res);
        }

        public DataSet BuscarMesa(int id_mesa, int id_res)
        {
            return TR.BuscarMesa(id_mesa, id_res);
        }

        public bool EliminarMesa(int id_mesa)
        {
            return TR.EliminarMesa(id_mesa);
        }

        public bool LiberarMesa(int id, int id_res)
        {
            return true;
        }

        public bool AgregarIngrediente(int id_res, string ingrediente, int precio, int cantidad)
        {
            if (ingrediente != "" && precio != 0 && cantidad != 0)
            {
                return TR.AgregarIngrediente(id_res, ingrediente, precio, cantidad);
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
                return TR.ModificarIngrediente(id_ing, ingrediente, precio, cantidad);
            }
            else
            {
                return false;
            }
        }

        public DataSet ConsultarStock(int id_res)
        {
            return TR.ConsultarStock(id_res);
        }

        public DataSet BuscarIngrediente(int id_ing, int id_res)
        {
            return TR.BuscarIngrediente(id_ing, id_res);
        }

        public bool EliminarIngrediente(int id_ing)
        {
            return TR.EliminarIngrediente(id_ing);
        }

        public bool AgregarPlato(int id_res, string nombre, string descripcion, int precio)
        {
            if (nombre != "" && descripcion != "" && precio != 0)
            {
                return TR.AgregarPlato(id_res, nombre, descripcion, precio);
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
                return TR.ModificarPlato(id_plato, nombre, descripcion, precio);
            }
            else
            {
                return false;
            }
        }

        public DataSet CargarComboPlatos(int id_res)
        {
            return new DataSet();
        }

        public DataSet ConsultarPlatos(int id_res)
        {
            return TR.ConsultarPlatos(id_res);
        }

        public DataSet BuscarPlato(int id_plato, int id_res)
        {
            return TR.BuscarPlato(id_plato, id_res);
        }

        public bool EliminarPlato(int id_plato)
        {
            return TR.EliminarPlato(id_plato);
        }

        public bool AsignarEmpleadoaMesa(int id_mesa, string id_emp)
        {
            return TR.AsignarEmpleadoaMesa(id_mesa, id_emp);
        }

        public bool QuitarEmpleadodeMesa(int id_mesa)
        {
            return TR.QuitarEmpleadodeMesa(id_mesa);
        }

        public bool QuitarPedidodeMesa(int id_mesa)
        {
            return TR.QuitarPedidodeMesa(id_mesa);
        }
    }
}