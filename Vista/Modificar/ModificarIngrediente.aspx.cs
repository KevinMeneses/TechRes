using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class ModificarIngrediente : System.Web.UI.Page
    {
        controlStock CS = new controlStock();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txNombre.Text = Session["ingrediente"].ToString();
                txPrecio.Text = Session["precio"].ToString();
                txCantidad.Text = Session["cantidad"].ToString();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            int id_ing = int.Parse(Session["id"].ToString());
            string ingrediente = txNombre.Text;
            int precio = int.Parse(txPrecio.Text);
            int cantidad = int.Parse(txCantidad.Text);

            bool respuesta = CS.ModificarIngrediente(id_ing, ingrediente, precio, cantidad);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El ingrediente fue modificado exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido modificar el ingrediente";
            }
        }
    }
}