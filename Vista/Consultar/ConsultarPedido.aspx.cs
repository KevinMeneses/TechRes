using Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class ConsultarPedido : System.Web.UI.Page
    {
        controlPedido CP = new controlPedido();
        int id_res = Restaurante.IdRestaurante;
        DataSet datos = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btModificar.CssClass = "btn btn-warning";
                btEliminar.CssClass = "btn btn-danger";
                CargarPedidos();
            }
        }

        private void CargarPedidos()
        {
            datos = CP.ConsultarPedidos(id_res);
            gvPedido.DataSource = datos;
            gvPedido.DataBind();
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            Session["id_pedido"] = gvPedido.Rows[0].Cells[0].Text;
            Session["descripcion"] = gvPedido.Rows[0].Cells[1].Text;
            Session["id_mesa"] = gvPedido.Rows[0].Cells[2].Text;
            Response.Redirect("~/Modificar/ModificarPedido.aspx");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text != "")
            {
                int id_ped = int.Parse(txBuscar.Text);

                datos = CP.BuscarPedido(id_ped, id_res);
                gvPedido.DataSource = datos;
                gvPedido.DataBind();

                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            else
            {
                CargarPedidos();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            int id_ped = int.Parse(txBuscar.Text);
            CP.EliminarPlatosdelPedido(id_ped);
            bool respuesta = CP.EliminarPedido(id_ped);
            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El pedido se ha eliminado exitosamente.";
                txBuscar.Text = "";
                CargarPedidos();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido eliminar el pedido, quizás tiene una mesa asignada, libere la mesa.";
            }
        }
    }
}