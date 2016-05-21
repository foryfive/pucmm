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
        private void buscar()
        {
            this.Grid.DataSource = Ncarrera.Buscar(this.txtbuscar.Text);
            this.Grid.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                buscar();
            }
        }
    }
}