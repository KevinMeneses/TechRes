using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Principales/Registrarse.aspx");
        }

        protected void btIngresar_Click(object sender, EventArgs e)
        {
            string correo = txCorreo.Text;
            string contra = txContrasena.Text;

            int respuesta = CR.IniciarSesion(correo, contra);

            if (respuesta != 0)
            {
                Restaurante.IdRestaurante = respuesta;
                Response.Redirect("~/Principales/GestionarRestaurante.aspx");
            }
            else
            {
                lbError.Text = "* El correo o la contraseña son incorrectos";                 
            }
        }
    }
}