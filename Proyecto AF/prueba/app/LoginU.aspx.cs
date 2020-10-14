using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;


namespace prueba.app
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroU.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            string sql = string.Empty;
            string usuario = user.Text;
            string contra = pass.Text;
            string connectionString = @"Data Source=LAPTOP-LAS89DVA;Initial Catalog=registroU;Integrated Security=True;";
            SqlConnection sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();

            sql = string.Format("Select NombreUsuario,Contrasenia from USUARIO where NombreUsuario='{0}' and Contrasenia='{1}'", usuario, contra);
            SqlCommand coma = new SqlCommand(sql, sqlcon);
            SqlDataReader reg = null;
            reg = coma.ExecuteReader();
            if (reg.Read() == true)
            {
                resultado = true;
                
            }
            else
            {
                resultado = false;
                noti.Visible = true;
            }

            if (resultado == true)
            {
                
                Response.Redirect("PantallaP.aspx?nombreU=" + user.Text);
            }
            else
            {

            }
        }

        protected void BPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaP.aspx");
        }
    }
}