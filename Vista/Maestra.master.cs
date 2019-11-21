using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant.Principales
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Restaurante.IdRestaurante == 0)
            {
                hlTechres.NavigateUrl = "~/IniciarSesion.aspx";
                lbSalir.Visible = false;
            }
        }

        protected void lbSalir_Click(object sender, EventArgs e)
        {
            Restaurante.IdRestaurante = 0;
            Response.Redirect("~/IniciarSesion.aspx");
        }
    }
}