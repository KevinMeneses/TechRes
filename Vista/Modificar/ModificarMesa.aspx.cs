using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechRestaurant
{
    public partial class ModificarMesa : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txNumero.Text = Session["mesa"].ToString();
                txCantSillas.Text = Session["sillas"].ToString();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            int id_mesa = int.Parse(Session["id"].ToString());
            int mesa = int.Parse(txNumero.Text);
            int sillas = int.Parse(txCantSillas.Text);

            bool respuesta = CR.ModificarMesa(id_mesa, mesa, sillas);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* La mesa fue modificada exitosamente";
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido modificar la mesa";
            }
        }
    }
}