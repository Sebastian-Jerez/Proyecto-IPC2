using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba.app
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        public static string valJ1 = "1";
        public static string colorJ1 = "";
        public static string valJ2 = "";
        public static string colorJ2 = "";
        public static int turnoJ = 0;
        public static int estado = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["nomj"] != null)
            {
                nombreJ1.Text = Request.Params["nomj"];
            }

            if(!IsPostBack)
            {
                llenarListaU();
            }

            listaUsuarios.Enabled = false;
            nombreNR.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int turnoVal = r.Next(1, 3);
            turnoJ = turnoVal;
            valJ1 = nombreJ1.Text;
            valJ2 = nombreJ2.Text;
            estado = 1;
            Response.Redirect("Tablero.aspx");
        }

        protected void negro1_CheckedChanged(object sender, EventArgs e)
        {
            if(negro1.Checked == true)
            {
                blanco1.Checked = false;
                aleatorio1.Checked = false;
                negro2.Checked = false;
                aleatorio2.Checked = false;
                blanco2.Checked = true;

                colorJ1 = "black";
                colorJ2 = "white";
            }
        }

        protected void blanco1_CheckedChanged(object sender, EventArgs e)
        {
            if (blanco1.Checked == true)
            {
                negro1.Checked = false;
                aleatorio1.Checked = false;
                blanco2.Checked = false;
                aleatorio2.Checked = false;
                negro2.Checked = true;

                colorJ1 = "white";
                colorJ2 = "black";
            }
        }

        protected void aleatorio1_CheckedChanged(object sender, EventArgs e)
        {
            if (aleatorio1.Checked == true)
            {
                negro1.Checked = false;
                blanco1.Checked = false;
                negro2.Checked = false;
                blanco2.Checked = false;
                aleatorio2.Checked = true;

                colorJ1 = colorR();
                if (colorJ1 == "black")
                {
                    colorJ2 = "white";
                }
                else
                {
                    colorJ2 = "black";
                }
            }
        }

        protected void userR_CheckedChanged(object sender, EventArgs e)
        {
            if (userR.Checked == true)
            {
                userNR.Checked = false;
                listaUsuarios.Enabled = true;
                nombreNR.Enabled = false;
            }
        }

        protected void userNR_CheckedChanged(object sender, EventArgs e)
        {
            if (userNR.Checked == true)
            {
                userR.Checked = false;
                nombreNR.Enabled = true;
                listaUsuarios.Enabled = false;
            }
        }

        private void llenarListaU()
        {
            listaUsuarios.DataSource = consultaU("SELECT * FROM USUARIO");
            listaUsuarios.DataTextField = "NombreUsuario";
            listaUsuarios.DataValueField = "NombreUsuario";
            listaUsuarios.DataBind();
        }

        public DataSet consultaU(string strSQL)
        {
            string cons = "Data Source=LAPTOP-LAS89DVA;Initial Catalog=registroU;Integrated Security=True";
            SqlConnection conec = new SqlConnection(cons);
            conec.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conec);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet dset = new DataSet();
            adap.Fill(dset);
            conec.Close();
            return dset;
        }

        protected void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreJ2.Text = listaUsuarios.SelectedValue;
        }

        protected void nombreNR_TextChanged(object sender, EventArgs e)
        {
            nombreJ2.Text = nombreNR.Text;
        }

        protected void negro2_CheckedChanged(object sender, EventArgs e)
        {
            if (negro2.Checked == true)
            {
                blanco2.Checked = false;
                aleatorio2.Checked = false;
                negro1.Checked = false;
                aleatorio1.Checked = false;
                blanco1.Checked = true;

                colorJ2 = "black";
                colorJ1 = "white";
            }
        }

        protected void blanco2_CheckedChanged(object sender, EventArgs e)
        {
            if (blanco2.Checked == true)
            {
                aleatorio2.Checked = false;
                negro1.Checked = true;
                aleatorio1.Checked = false;
                blanco1.Checked = false;
                negro2.Checked = false;

                colorJ2 = "white";
                colorJ1 = "black";
            }
        }

        protected void aleatorio2_CheckedChanged(object sender, EventArgs e)
        {
            if (aleatorio2.Checked == true)
            {
                negro1.Checked = false;
                aleatorio1.Checked = true;
                blanco1.Checked = false;
                negro2.Checked = false;
                blanco2.Checked = false;

                colorJ2 = colorR();
                if (colorJ2 == "black")
                {
                    colorJ1 = "white";
                }
                else
                {
                    colorJ1 = "black";
                }
            }
        }

        public string colorR()
        {
            string col = "";
            Random r = new Random();
            int colorVal = r.Next(1, 3);
            if (colorVal == 1)
            {
                col = "balck";
            }
            else if(colorVal == 2)
            {
                col = "white";
            }
            return col;
        }
    }
}