using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;
namespace emprende
{
    public partial class Carrera : System.Web.UI.Page
    {
        private static Boolean editar = false; 
        private void limpiar()
        {
            this.txtdescripcion.Text = "";
            this.txtid.Text = "";
        }
        private void Habilitar(Boolean b)
        {
            this.txtdescripcion.Enabled = b;
            this.btncancelar.Visible    = b;
            this.btngrabar.Visible      = b;

            this.btnnuevo.Visible = !b;
 
            this.panel.Visible = !b;
            this.divbuscar.Visible = !b;

        }
        private void Habilitar2(Boolean b )
        {
            this.btnmodificar.Visible = b;
            this.btneliminar.Visible = b;
        }
        private void buscar()
        {
            this.Grid.DataSource = Ncarrera.Buscar(this.txtbuscar.Text);
            this.Grid.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                Habilitar(false);
                Habilitar2(false);
                buscar();
               
            }
        }

        protected void Grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Grid.Rows.Count > 0)
            {
                this.txtid.Text = this.Grid.SelectedRow.Cells[1].Text;
                this.txtdescripcion.Text = this.Grid.SelectedRow.Cells[2].Text;
                Habilitar2(true);
            }
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            Habilitar2(false);
            editar = false;
            limpiar();
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            Habilitar2(false);
            limpiar();
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            Habilitar2(false);
            Habilitar(true);
            editar = true;
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            Ecarrera c = new Ecarrera();
          //  c.descripcion = this.txtdescripcion.Text.ToUpper();
            c.idcarrera = (this.txtid.Text != "") ? int.Parse(this.txtid.Text) : 0;
            c.accion = (editar) ? "U" : "I";
            try
            {
                int i = Ncarrera.Sentencia(c);
                if (c.accion == "I")
                    this.txtid.Text = i.ToString();            

                Habilitar(false);
                Habilitar2(true);
                buscar();
                ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "  $.notify('Datos Grabados!', 'success');", true);

            }
            catch(Exception ex)
            {

            }
            
        }

        protected void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}