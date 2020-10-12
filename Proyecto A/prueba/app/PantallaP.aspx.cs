using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace prueba.app
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static int carga = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Params["nombreU"] != null)
            {
                nomU.Text = Request.Params["nombreU"];
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginU.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosPartidaUcU.aspx?nomj=" + nomU.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            carga = 1;
            Response.Redirect("Tablero.aspx");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosPartidaUcU.aspx");

        }
    }
}