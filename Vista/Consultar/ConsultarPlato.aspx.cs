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
    public partial class ConsultarPlato : System.Web.UI.Page
    {
        controlPlato CP = new controlPlato();
        DataSet datos = new DataSet();
        int id_res = Restaurante.IdRestaurante;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btModificar.CssClass = "btn btn-warning";
                btEliminar.CssClass = "btn btn-danger";
                CargarPlatos();
            }
        }

        private void CargarPlatos()
        {            
            datos = CP.ConsultarPlatos(id_res);
            gvPlato.DataSource = datos;
            gvPlato.DataBind();
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            Session["id"] = gvPlato.Rows[0].Cells[0].Text;
            Session["nombre"] = gvPlato.Rows[0].Cells[1].Text;
            Session["descripcion"] = gvPlato.Rows[0].Cells[2].Text;
            Session["precio"] = gvPlato.Rows[0].Cells[3].Text;
            Response.Redirect("~/Modificar/ModificarPlato.aspx");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text != "")
            {
                int id_plato = int.Parse(txBuscar.Text);

                datos = CP.BuscarPlato(id_plato, id_res);
                gvPlato.DataSource = datos;
                gvPlato.DataBind();

                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            else
            {
                CargarPlatos();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            int id_plato = int.Parse(txBuscar.Text);
            bool respuesta = CP.EliminarPlato(id_plato);
            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El plato se ha eliminado exitosamente.";
                txBuscar.Text = "";
                CargarPlatos();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido eliminar el plato.";
            }
        }
    }
}