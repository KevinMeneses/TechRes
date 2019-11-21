using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class AgregarIngrediente : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {
            int id_res = Restaurante.IdRestaurante;
            string ingrediente = txIngrediente.Text;
            int precio = int.Parse(txPrecio.Text);
            int cantidad = int.Parse(txCantidad.Text);

            bool respuesta = CR.AgregarIngrediente(id_res, ingrediente, precio, cantidad);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El ingrediente fue agregado exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido agregar el ingrediente";
            }
        }
    }
}