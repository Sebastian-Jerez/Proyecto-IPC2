using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba.app
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        public static string name;
        public static string ape;
        public static string nameU;
        public static string mailU;
        public static string fechaN;
        public static string paisU;

        public static string PG;
        public static string PE;
        public static string PP;
        public static string TG;
        public static string TP;
        public static string PT;


        protected void Page_Load(object sender, EventArgs e)
        {
            nombre.Text = name;
            apellido.Text = ape;
            user.Text = nameU;
            mail.Text = mailU;
            fecha.Text = fechaN;
            pa.Text = paisU;
            partidag.Text = PG;
            partidasE.Text = PE;
            per2.Text = PP;
            tj2.Text = TP;
            tg2.Text = TG;
            ptst2.Text = PT;
        }

        protected void pp_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaP.aspx");
        }
    }
}