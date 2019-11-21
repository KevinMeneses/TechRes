using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class GestionarRestaurante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btFacturacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Facturacion.aspx");
        }

        protected void btAgregarEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Agregar/AgregarEmpleado.aspx");
        }

        protected void btBuscarEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Consultar/ConsultarEmpleado.aspx");
        }

        protected void btAgregarPed_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Agregar/AgregarPedido.aspx");
        }

        protected void btBuscarPed_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Consultar/ConsultarPedido.aspx");
        }

        protected void btAgregarMesa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Agregar/AgregarMesa.aspx");
        }

        protected void btBuscarMesa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Consultar/ConsultarMesa.aspx");
        }

        protected void btAgregarIng_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Agregar/AgregarIngrediente.aspx");
        }

        protected void btBuscarIng_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Consultar/ConsultarStock.aspx");
        }

        protected void btAgregarPlato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Agregar/AgregarPlato.aspx");
        }

        protected void btBuscarPlato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Consultar/ConsultarPlato.aspx");
        }
    }
}