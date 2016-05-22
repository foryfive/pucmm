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
        private static Boolean editar = false;
        private void buscar()
        {

            this.Grid.DataSource = Npersonas.Buscar(this.txtbuscar.Text);
            this.DataBind();

        }

        private void limpiar()
        {
            this.txtid.Text          = "";
            this.txtnombre.Text      = "";
            this.txtcedula.Text      = "";
            this.txtclave.Text       = "";
            this.txtrepitaclave.Text = "";
            this.txtusuario.Text     = "";   
        }
        private void Habilitar(Boolean b)
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
    }
}