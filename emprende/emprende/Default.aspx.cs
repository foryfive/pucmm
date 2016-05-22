using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using System.Data;
using System.Web.Security;

namespace emprende
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                if (Session["id"].ToString() != "")
                    Response.Redirect("Inicio.aspx");
            }
        }

        protected void btniniciar_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = this.txtusuario.Value;
            pass = this.txtclave.Value;
            DataTable dt = Ninisiarsesion.InisiaSesion(user, pass);
            if (dt.Rows.Count > 0)
            {
                Session["login"] = dt.Rows[0]["idpersona"].ToString();
                Response.Redirect("Inicio.aspx");
                FormsAuthentication.RedirectFromLoginPage(user, false);
            }
            else
            {
                Session["login"] = "";
                ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "$.notify('Usuario o clave inicorrectos!','warn') ", true);
            }

        }
    }
}