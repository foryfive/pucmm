﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emprende
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
                this.titulo.Text = Session["usuario"].ToString();
        }



        protected void btncerrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}