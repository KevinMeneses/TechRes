using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class AgregarEmpleado : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {
            int id_res = Restaurante.IdRestaurante;
            string id_emp = txId.Text;            
            string nombre = txNombre.Text;
            string apellido = txApellido.Text;
            string correo = txCorreo.Text;
            string cargo = txCargo.Text;
            string contra = txContrasena.Text;

            bool respuesta = CR.AgregarEmpleado(id_emp, id_res, nombre, apellido, correo, cargo, contra);

            if(respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El empleado fue agregado exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido agregar el empleado";
            }
        }
    }
}