using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidades;
namespace emprende
{
    public partial class Proyecto1 : System.Web.UI.Page
    {
        private void llenargrid()
        {
            this.Grid.DataSource = Ncategoria.Buscar("");
            this. Grid.DataBind();
        } 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenargrid();
            }
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            Eproyecto p = new Eproyecto();
            EproyectoCategoria ep = new EproyectoCategoria();
            p.accion = "I";
            p.descripcion = this.txtdescripcion.Value.ToUpper();
            p.titulo = this.txttitulo.Text;
            p.estado = "A";
            p.fechaPublicacion = DateTime.Now;
            p.puntos = 0;
            p.idpersona = (Session["id"] != null) ? Convert.ToInt32(Session["id"].ToString()):0 ;

            try
            {
                int id = Nproyecto.Sentencia(p);
                foreach (GridViewRow item in this.Grid.Rows)
                {
                    if (item.Cells[1].Controls[1] is CheckBox)
                    {
                        CheckBox ck = item.Cells[1].Controls[1] as CheckBox;
                        if (ck.Checked == true)
                        {
                            ep.idproyecto = id;
                            ep.idcategoria = int.Parse(Grid.DataKeys[item.RowIndex][0].ToString());

                            NproyectoCategoria.Sentencia(ep);
                        }
                    }
                }
                ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "$.notify('Datos Enviados!','success');", true); 
            }
            catch (Exception ex)
            {

               
            }

            

            

            
        }
    }
}