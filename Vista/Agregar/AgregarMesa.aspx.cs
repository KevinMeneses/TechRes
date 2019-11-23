using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class AgregarMesa : System.Web.UI.Page
    {
        controlMesas CM = new controlMesas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {
            int id_res = Restaurante.IdRestaurante;
            int mesa = int.Parse(txNumero.Text);
            int sillas = int.Parse(txCantSillas.Text);

            bool respuesta = CM.AgregarMesa(id_res, mesa, sillas);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* La mesa fue agregada exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido agregar la mesa";
            }
        }
    }
}