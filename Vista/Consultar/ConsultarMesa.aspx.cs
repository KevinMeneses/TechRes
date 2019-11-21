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
    public partial class ConsultarMesa : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        int id_res = Restaurante.IdRestaurante;
        DataSet datos = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btModificar.CssClass = "btn btn-warning";
                btEliminar.CssClass = "btn btn-danger";
                CargarMesas();
            }
        }

        public void CargarMesas()
        {
            datos = CR.ConsultarMesas(id_res);
            gvMesa.DataSource = datos;
            gvMesa.DataBind();
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            Session["id"] = gvMesa.Rows[0].Cells[0].Text;
            Session["mesa"] = gvMesa.Rows[0].Cells[1].Text;
            Session["sillas"] = gvMesa.Rows[0].Cells[2].Text;
            Response.Redirect("~/Modificar/ModificarMesa.aspx");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text != "")
            {
                int id_mesa = int.Parse(txBuscar.Text);

                datos = CR.BuscarMesa(id_mesa, id_res);
                gvMesa.DataSource = datos;
                gvMesa.DataBind();

                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            else
            {
                CargarMesas();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            int id_mesa = int.Parse(txBuscar.Text);
            bool respuesta = CR.EliminarMesa(id_mesa);
            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* La mesa se ha eliminado exitosamente.";
                txBuscar.Text = "";
                CargarMesas();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido eliminar la mesa.";
            }
        }
    }
}