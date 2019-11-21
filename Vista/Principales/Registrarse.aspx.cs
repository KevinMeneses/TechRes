using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class Registrarse : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = txNombre.Text;
            string correo = txCorreo.Text;
            string contra = txContrasena.Text;

            bool respuesta = CR.Registrarse(nombre, correo, contra);

            if (respuesta)
            {
                Response.Redirect("~/IniciarSesion.aspx");
            }
            else
            {
                lbError.Text = "* No se ha podido registrar el usuario";
            }
        }
    }
}