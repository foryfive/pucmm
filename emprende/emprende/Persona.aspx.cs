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
    public partial class Persona : System.Web.UI.Page
    {
        private static Boolean editar = false; //variable encargada para modificar el registro
        private void buscar()
        {

            this.Grid.DataSource = Npersonas.Buscar(this.txtbuscar.Text);
            this.DataBind();

        }

        private void limpiar()  // limpiar todo los registro
        {
            this.txtid.Text          = "";
            this.txtnombre.Text      = "";
            this.txtcedula.Text      = "";
            this.txtclave.Text       = "";
            this.txtrepitaclave.Text = "";
            this.txtusuario.Text     = "";   
        }
        private void Habilitar(Boolean b) // habilitar los botones y formularios 
        {
            this.txtnombre.Enabled      = b;
            this.txtusuario.Enabled     = b;
            this.txtcedula.Enabled      = b;
            this.txtclave.Enabled       = b;
            this.txtrepitaclave.Enabled = b;
            this.cmbrol.Enabled         = b;
            this.cmbcarrera.Enabled     = false;
            this.btngrabar.Visible      = b;
            this.btncancelar.Visible    = b;
            this.btnnuevo.Visible       = !b;
            this.divbuscar.Visible      = !b;
            this.panel.Visible          = !b;
            
        }
        private void habilitar2(Boolean b)
        {
            this.btneliminar.Visible = b;
            this.btnmodificar.Visible = b;
            
        }
        private void llenarcombo()
        {
            this.cmbcarrera.DataSource = Ncarrera.Buscar("");
            this.cmbcarrera.DataValueField = "idcarrera";
            this.cmbcarrera.DataTextField = "descripcion";         
            this.cmbcarrera.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Habilitar(false);
                habilitar2(false);
                llenarcombo();
                buscar();
            }
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            habilitar2(false);
            Habilitar(true);
            this.txtcedula.Focus();

        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            Habilitar(false);
            habilitar2(false);
        }

        protected void Grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            // mostrar los datos desde el grid a los campos del webform
            if (this.Grid.Rows.Count > 0)
            {
                this.txtid.Text = this.Grid.SelectedRow.Cells[1].Text;
                this.txtcedula.Text      = this.Grid.SelectedRow.Cells[2].Text;
                this.txtnombre.Text      = this.Grid.SelectedRow.Cells[3].Text;
                this.txtusuario.Text     = this.Grid.SelectedRow.Cells[4].Text;
                this.txtclave.Text       = this.Grid.SelectedDataKey["clave"].ToString();
                this.txtrepitaclave.Text = this.txtclave.Text;

                this.cmbrol.SelectedValue     = this.Grid.SelectedDataKey["rol"].ToString();

                if (this.Grid.SelectedDataKey["idcarrera"].ToString() != "")
                    this.cmbcarrera.SelectedValue = this.Grid.SelectedDataKey["idcarrera"].ToString();


                habilitar2(true);

            }
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            editar = true;// se va a dodificar los datos eso indica la variable
            habilitar2(false); // falso algunos de los botones
            Habilitar(true);  // habilitamos todos los campos
            this.txtcedula.Focus();
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            Epersona p = new Epersona();
            p.idpersona = (this.txtid.Text != "") ? Convert.ToInt32(this.txtid.Text) : 0;
            p.accion    = (editar) ? "U" : "I";
            p.nombre    = this.txtnombre.Text;
            p.estado    = "A";
            p.cedula    = this.txtcedula.Text;
            p.clave     = this.txtclave.Text;
            p.rol       = (this.cmbrol.SelectedValue == "1") ? "1" : "2";
            p.idcarrera = Convert.ToInt32(this.cmbcarrera.SelectedValue);
            p.usuario   = this.txtusuario.Text;

            try
            {
               int id = Npersonas.Sentencia(p);
               if (!editar) this.txtid.Text = id.ToString();
                buscar();
                Habilitar(false);
                ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "$.notify('Datos grabados!','success');",true);  
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "$.notify('Error no se pudo grabar.','warm');",true);

            }
           


        }
    }
}