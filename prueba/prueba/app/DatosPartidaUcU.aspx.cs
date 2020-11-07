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
        public static int ap = 0;

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

            if(WebForm2.Maquina == 1)
            {
                userR.Visible = false;
                userR.Enabled = false;
                userNR.Visible = false;
                userNR.Enabled = false;
                listaUsuarios.Visible = false;
                listaUsuarios.Enabled = false;
                nombreNR.Visible = false;
                nombreNR.Enabled = false;
                nombreJ2.Text = "CPU";
            }

            if(ap == 0)
            {
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                C4.Enabled = false;
                C5.Enabled = false;
                C6.Enabled = false;
                C11.Enabled = false;
                C22.Enabled = false;
                C33.Enabled = false;
                C44.Enabled = false;
                C55.Enabled = false;
                C66.Enabled = false;
                ap = 1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int turnoVal = r.Next(1, 3);
            turnoJ = turnoVal;
            valJ1 = nombreJ1.Text;
            valJ2 = nombreJ2.Text;
            estado = 1;
            

            if(Minverso.Checked == true)
            {
                WebForm4.modoInverso = true;
            }
            else
            {
                WebForm4.modoInverso = false;
            }

            if(AP.Checked == true)
            {
                WebForm4.aperturaP = true;

                if(C1.Checked == true)
                {
                    WebForm4.listaColores1.Add("Rojo");
                }
                else if(C11.Checked == true)
                {
                    WebForm4.listaColores2.Add("Rojo");
                }

                if (C2.Checked == true)
                {
                    WebForm4.listaColores1.Add("Azul");
                }
                else if(C22.Checked == true)
                {
                    WebForm4.listaColores2.Add("Azul");
                }

                if (C3.Checked == true)
                {
                    WebForm4.listaColores1.Add("Negro");
                }
                else if(C33.Checked == true)
                {
                    WebForm4.listaColores2.Add("Negro");
                }

                if (C4.Checked == true)
                {
                    WebForm4.listaColores1.Add("Blanco");
                }
                else if (C44.Checked == true)
                {
                    WebForm4.listaColores2.Add("Blanco");
                }

                if (C5.Checked == true)
                {
                    WebForm4.listaColores1.Add("Morado");
                }
                else if (C55.Checked == true)
                {
                    WebForm4.listaColores2.Add("Morado");
                }

                if (C6.Checked == true)
                {
                    WebForm4.listaColores1.Add("Amarillo");
                }
                else if (C66.Checked == true)
                {
                    WebForm4.listaColores2.Add("Amarillo");
                }
            }

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

        protected void Minverso_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void AP_CheckedChanged(object sender, EventArgs e)
        {
            if(AP.Checked == true)
            {
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;
                C4.Enabled = true;
                C5.Enabled = true;
                C6.Enabled = true;
                C11.Enabled = true;
                C22.Enabled = true;
                C33.Enabled = true;
                C44.Enabled = true;
                C55.Enabled = true;
                C66.Enabled = true;
            }
            else
            {
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                C4.Enabled = false;
                C5.Enabled = false;
                C6.Enabled = false;
                C11.Enabled = false;
                C22.Enabled = false;
                C33.Enabled = false;
                C44.Enabled = false;
                C55.Enabled = false;
                C66.Enabled = false;
            }
        }

        protected void C1_CheckedChanged(object sender, EventArgs e)
        {
            if(C1.Checked == true)
            {
                C11.Checked = false;
            }
        }

        protected void C2_CheckedChanged(object sender, EventArgs e)
        {
            if(C2.Checked == true)
            {
                C22.Checked = false;
            }
        }

        protected void C3_CheckedChanged(object sender, EventArgs e)
        {
            if (C3.Checked == true)
            {
                C33.Checked = false;
            }
        }

        protected void C4_CheckedChanged(object sender, EventArgs e)
        {
            if (C4.Checked == true)
            {
                C44.Checked = false;
            }
        }

        protected void C5_CheckedChanged(object sender, EventArgs e)
        {
            if (C5.Checked == true)
            {
                C55.Checked = false;
            }
        }

        protected void C6_CheckedChanged(object sender, EventArgs e)
        {
            if (C6.Checked == true)
            {
                C66.Checked = false;
            }
        }

        protected void C11_CheckedChanged(object sender, EventArgs e)
        {
            if (C11.Checked == true)
            {
                C1.Checked = false;
            }
        }

        protected void C22_CheckedChanged(object sender, EventArgs e)
        {
            if (C22.Checked == true)
            {
                C2.Checked = false;
            }
        }

        protected void C33_CheckedChanged(object sender, EventArgs e)
        {
            if (C33.Checked == true)
            {
                C3.Checked = false;
            }
        }
    }
}