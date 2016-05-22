using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using System.Data;
namespace emprende
{
    public partial class Inicio : System.Web.UI.Page
    {   
        private void publicar()
        {
            string html;
            DataTable dt = Nproyecto.Buscar("");
            foreach (DataRow item in dt.Rows)
            {
                html = "";
                html = "<div class='row well' >";
                html += "<div class='col-md-8' >";
                html += "<h2>"+item["titulo"].ToString()+"</h2>";
                html += "<p>Fecha publicación: "  + item["fechapublicacion"].ToString() + "</p>";
                html += "<p>"+item["descripcion"].ToString()+"</p> <br/>";
                html += "<label>Comentario</label>";
                html += "<br/> <textarea class='form-control' cols='4' rows='2'  ></textarea>";
                html += "<br/> <button class='btn btn-primary' >Publicar Comentario</button>";
                html += "</div>";
                html += "</div>";
                this.divcontenido.InnerHtml += html;
            }
            
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["login"] != null)
                {
                    if (Session["login"].ToString() == "")
                        Response.Redirect("Default.aspx");
                }
                else
                    Response.Redirect("Default.aspx");
                publicar();
            }
        }
    }
}