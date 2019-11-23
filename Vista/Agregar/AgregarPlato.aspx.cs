using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class AgregarPlato : System.Web.UI.Page
    {
        controlPlato CP = new controlPlato();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {
            int id_res = Restaurante.IdRestaurante;
            string nombre = txNombre.Text;
            string descripcion = txDescripcion.Text;
            int precio = int.Parse(txPrecio.Text);

            bool respuesta = CP.AgregarPlato(id_res, nombre, descripcion, precio);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El plato fue agregado exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido agregar el plato";
            }
        }
    }
}