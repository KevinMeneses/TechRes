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
    public partial class ModificarEmpleado : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txId.Text = Session["id"].ToString();
                txNombre.Text = Session["nombre"].ToString();
                txApellido.Text = Session["apellido"].ToString();
                txCorreo.Text = Session["correo"].ToString();
                txCargo.Text = Session["cargo"].ToString();
            }            
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            string id_viejo = Session["id"].ToString();
            string id_nuevo = txId.Text;
            string nombre = txNombre.Text;
            string apellido = txApellido.Text;
            string correo = txCorreo.Text;
            string cargo = txCargo.Text;
            string contra = txContrasena.Text;

            bool respuesta = CR.ModificarEmpleado(id_viejo, id_nuevo, nombre, apellido, correo, cargo, contra);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El empleado fue modificado exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido modificar el empleado";
            }
        }
    }
}