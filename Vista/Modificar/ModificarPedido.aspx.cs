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
    public partial class ModificarPedido : System.Web.UI.Page
    {
        controlPedido CP = new controlPedido();
        controlPlato CPL = new controlPlato();
        controlMesas CM = new controlMesas();
        DataSet datos = new DataSet();
        DataSet mesas = new DataSet();
        DataSet platos = new DataSet();
        int id_res = Restaurante.IdRestaurante;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                CargarDatos();
                ObtenerTotal();
                CargarPlatos();
                CargarMesas();
                ddlMesa.SelectedValue = Session["id_mesa"].ToString();                
                txDescripcion.Text = Session["descripcion"].ToString();
            }
            else
            {
                datos = (DataSet)ViewState["DataSet"];
            }

            ViewState["DataSet"] = datos;
        }

        private void CargarDatos()
        {
            int id_pedido = int.Parse(Session["id_pedido"].ToString());
            datos = CP.ConsultarPedidoMesa(id_pedido);
            gvPedido.DataSource = datos;
            gvPedido.DataBind();           
        }

        private void CargarPlatos()
        {
            platos = CPL.ConsultarPlatos(id_res);
            ddlPlatos.DataSource = platos;
            ddlPlatos.DataValueField = "id";
            ddlPlatos.DataTextField = "nombre";
            ddlPlatos.DataBind();
            decimal precio = platos.Tables[0].Rows[0].Field<decimal>("precio");
            lbPrecio.Text = precio.ToString();
        }

        private void CargarMesas()
        {
            mesas = CM.ConsultarMesas(id_res);
            ddlMesa.DataSource = mesas;
            ddlMesa.DataValueField = "id";
            ddlMesa.DataTextField = "numero_mesa";
            ddlMesa.DataBind();
            ddlMesa.Items.Insert(0, new ListItem("Ninguna", "0"));
        }

        protected void ddlPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            platos = CPL.ConsultarPlatos(id_res);
            int fila = ddlPlatos.SelectedIndex;
            decimal precio = platos.Tables[0].Rows[fila].Field<decimal>("precio");
            lbPrecio.Text = precio.ToString();
        }

        protected void gvPedido_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int indice = Convert.ToInt32(e.CommandArgument);

                ((DataSet)ViewState["DataSet"]).Tables[0].Rows[indice].Delete();
                ((DataSet)ViewState["DataSet"]).AcceptChanges();

                ActualizarTabla();
                ObtenerTotal();
            }
        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {
            DataRow fila;

            fila = datos.Tables[0].NewRow();
            fila["id"] = ddlPlatos.SelectedValue;
            fila["nombre"] = ddlPlatos.SelectedItem;
            fila["precio"] = lbPrecio.Text;

            datos.Tables[0].Rows.Add(fila);

            ActualizarTabla();
            ObtenerTotal();
        }

        private void ActualizarTabla()
        {
            gvPedido.DataSource = datos;
            gvPedido.DataBind();
        }

        protected void btAsignar_Click(object sender, EventArgs e)
        {
            int total = int.Parse(lbTotal.Text);
            int id_mesa = int.Parse(ddlMesa.SelectedValue.ToString());
            string descripcion = txDescripcion.Text;
            int id_pedido = int.Parse(Session["id_pedido"].ToString());

            bool respuesta = CP.ModificarPedido(id_pedido, id_mesa, descripcion, total);

            if (respuesta)
            {
                AsignarPedido();
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido modificar el pedido";
            }
        }

        private void AsignarPedido()
        {
            int id_pedido = int.Parse(Session["id_pedido"].ToString());
            int id_plato = 0;

            bool respuesta2 = CP.EliminarPlatosdelPedido(id_pedido);
            bool respuesta3 = true;

            for (int i = 0; i < gvPedido.Rows.Count; i++)
            {
                id_plato = Convert.ToInt32(((DataSet)ViewState["DataSet"]).Tables[0].Rows[i].Field<decimal>("id"));
                respuesta3 = CP.AgregarPlatoPedido(id_res, id_pedido, id_plato);
            }

            if (respuesta3)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El pedido fue modificado exitosamente";
            }
            else
            {
                lbMensaje.Text = respuesta3.ToString();
                lbError.Text = "* No se ha podido modificar el pedido";
            }
        }

        private void ObtenerTotal()
        {
            decimal total = 0;

            for (int i = 0; i < gvPedido.Rows.Count; i++)
            {
                total += datos.Tables[0].Rows[i].Field<decimal>("precio");
            }

            lbTotal.Text = total.ToString();
        }
    }
}