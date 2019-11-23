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
    public partial class ConsultarStock : System.Web.UI.Page
    {
        controlStock CS = new controlStock();
        int id_res = Restaurante.IdRestaurante;
        DataSet datos = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btModificar.CssClass = "btn btn-warning";
                btEliminar.CssClass = "btn btn-danger";
                CargarStock();
            }
        }

        public void CargarStock()
        {
            datos = CS.ConsultarStock(id_res);
            gvStock.DataSource = datos;
            gvStock.DataBind();
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            Session["id"] = gvStock.Rows[0].Cells[0].Text;
            Session["ingrediente"] = gvStock.Rows[0].Cells[1].Text;
            Session["precio"] = gvStock.Rows[0].Cells[2].Text;
            Session["cantidad"] = gvStock.Rows[0].Cells[3].Text;
            Response.Redirect("~/Modificar/ModificarIngrediente.aspx");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text != "")
            {
                int id_ing = int.Parse(txBuscar.Text);

                datos = CS.BuscarIngrediente(id_ing, id_res);
                gvStock.DataSource = datos;
                gvStock.DataBind();

                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            else
            {
                CargarStock();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            int id_ing = int.Parse(txBuscar.Text);
            bool respuesta = CS.EliminarIngrediente(id_ing);
            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El ingrediente se ha eliminado exitosamente.";
                txBuscar.Text = "";
                CargarStock();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido eliminar el ingrediente.";
            }
        }
    }
}