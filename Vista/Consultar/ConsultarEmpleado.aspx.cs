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
    public partial class ConsultarEmpleado : System.Web.UI.Page
    {
        controlEmpleado CE = new controlEmpleado();     
        int id_res = Restaurante.IdRestaurante;
        DataSet datos = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)
            {
                btModificar.CssClass = "btn btn-warning";
                btEliminar.CssClass = "btn btn-danger";
                CargarEmpleados();
            }            
        }

        public void CargarEmpleados()
        {
            datos = CE.ConsultarEmpleados(id_res);
            gvEmpleado.DataSource = datos;
            gvEmpleado.DataBind();            
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            string id_emp = txBuscar.Text;
            bool respuesta = CE.EliminarEmpleado(id_emp);
            if(respuesta)
            {
                lbError.Text = "";
                lbMensaje.Text = "* El empleado se ha eliminado exitosamente.";
                txBuscar.Text = "";
                CargarEmpleados();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
            else
            {
                lbMensaje.Text = "";
                lbError.Text = "* No se ha podido eliminar el empleado.";
            }
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            Session["id"] = gvEmpleado.Rows[0].Cells[0].Text;
            Session["nombre"] = gvEmpleado.Rows[0].Cells[1].Text;
            Session["apellido"] = gvEmpleado.Rows[0].Cells[2].Text;
            Session["correo"] = gvEmpleado.Rows[0].Cells[3].Text;
            Session["cargo"] = gvEmpleado.Rows[0].Cells[4].Text;
            Response.Redirect("~/Modificar/ModificarEmpleado.aspx");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text != "")
            {
                string id_emp = txBuscar.Text;                               

                datos = CE.BuscarEmpleado(id_emp, id_res);
                gvEmpleado.DataSource = datos;
                gvEmpleado.DataBind();                

                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            else
            {
                CargarEmpleados();
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }            
        }
    }
}