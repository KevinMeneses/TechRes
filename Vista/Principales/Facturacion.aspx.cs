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
    public partial class Facturacion : System.Web.UI.Page
    {
        controlRes CR = new controlRes();
        int id_res = Restaurante.IdRestaurante;
        DataSet mesas = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }            
        }

        private void CargarDatos()
        {
            DataSet empleados = new DataSet();

            empleados = CR.ConsultarEmpleados(id_res);
            mesas = CR.ConsultarMesas(id_res);

            gvMesas.DataSource = mesas;
            gvMesas.DataBind();

            empleados.Tables[0].Columns.Add(new DataColumn("empleado", System.Type.GetType("System.String"), "nombre + '  ' + apellido"));

            ddlEmpleado.DataSource = empleados;
            ddlEmpleado.DataValueField = "id";
            ddlEmpleado.DataTextField = "empleado";
            ddlEmpleado.DataBind();            

            ddlMesa.DataSource = mesas;
            ddlMesa.DataValueField = "id";
            ddlMesa.DataTextField = "numero_mesa";
            ddlMesa.DataBind();

        }

        protected void gvMesas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                mesas = CR.ConsultarMesas(id_res);
                int indice = Convert.ToInt32(e.CommandArgument);
                int id_mesa = int.Parse(gvMesas.Rows[indice].Cells[0].Text);
                int mesa = int.Parse(gvMesas.Rows[indice].Cells[1].Text);
                decimal id_pedido = (mesas.Tables[0].Rows[indice].Field<decimal?>("id_pedido") as decimal?) ?? 0;
                Session["id_pedido"] = id_pedido;
                Session["id_mesa"] = id_mesa;
                Session["mesa"] = mesa;
                Response.Redirect("~/Principales/PedidoMesa.aspx");
            }
        }

        protected void btQuitar_Click(object sender, EventArgs e)
        {
            int id_mesa = int.Parse(ddlMesa.SelectedValue);
            bool respuesta = CR.QuitarEmpleadodeMesa(id_mesa);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El empleado fue liberado exitosamente";
                CargarDatos();
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido liberar el empleado";
            }
        }

        protected void btAsignar_Click(object sender, EventArgs e)
        {
            int id_mesa = int.Parse(ddlMesa.SelectedValue);
            string id_emp = ddlEmpleado.SelectedValue;
            bool respuesta = CR.AsignarEmpleadoaMesa(id_mesa, id_emp);

            if (respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El empleado fue asignado exitosamente";
                CargarDatos();
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido asignar el empleado";
            }
        }
    }
}