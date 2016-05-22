using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emprende
{
    public partial class Proyecto : System.Web.UI.Page
    {
        private void publicar(int id)
        {
            string html;
            int i = 0;
            DataTable dt = Nproyecto.Buscar(id);
            foreach (DataRow item in dt.Rows)
            {
                i++;
                html = "";
                html = "<div class='row well' >";
                html += "<div class='col-md-8' >";
                html += "<input class='form-control' type='text' id='txt"+i.ToString()+"' value='" + item["titulo"].ToString() + "' />";
                html += "<br/> <textarea class='form-control' cols='4' rows='2'  >"+ item["descripcion"].ToString() + "</textarea>";
                html += "<br/> <asp:button id='btn"+i.ToString()+ "' runat='server'  class='btn btn-primary'>Publicar Comentario</asp:button> ";
                html += "</div>";
                html += "</div>";                  
                this.divcontenido.InnerHtml += html;
            }


        }

        private void B_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "  $.notify('Datos Grabados!', 'success');", true);
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = (Session["login"] != null) ? int.Parse(Session["login"].ToString()) : 0;
                publicar(1);
            }
        }
    }
}