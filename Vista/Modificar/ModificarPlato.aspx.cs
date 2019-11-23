using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class ModificarPlato : System.Web.UI.Page
    {
        controlPlato CP = new controlPlato();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txNombre.Text = Session["nombre"].ToString();
                txDescripcion.Text = Session["descripcion"].ToString();
                txPrecio.Text = Session["precio"].ToString();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            int id_plato = int.Parse(Session["id"].ToString());
            string nombre = txNombre.Text;
            string descripcion = txDescripcion.Text;
            int precio = int.Parse(txPrecio.Text);

            bool respuesta = CP.ModificarPlato(id_plato, nombre, descripcion, precio);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El plato fue modificado exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido modificar el plato";
            }
        }
    }
}