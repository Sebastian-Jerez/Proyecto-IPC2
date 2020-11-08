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
    public partial class WebForm6 : System.Web.UI.Page
    {
        public static int cantColoresJ1;
        public static int cantColoresJ2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["nomj"] != null)
            {
                nombreJ1.Text = Request.Params["nomj"];
            }

            if (!IsPostBack)
            {
                llenarListaU();
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;

            }

            listaUsuarios.Enabled = false;
            nombreNR.Enabled = false;
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

        private void llenarListaU()
        {
            listaUsuarios.DataSource = consultaU("SELECT * FROM USUARIO");
            listaUsuarios.DataTextField = "NombreUsuario";
            listaUsuarios.DataValueField = "NombreUsuario";
            listaUsuarios.DataBind();
        }

        protected void comenzar_Click(object sender, EventArgs e)
        {
            bool validoMN = false;
            bool valColores1 = false;
            bool valColores2 = false;

            int filas = Convert.ToInt32(M.Text);
            int columnas = Convert.ToInt32(N.Text);

            if ((columnas >= 6) & (columnas <= 20) & (filas <= 20) & (filas <= 20) & (filas%2 == 0) & (columnas%2 == 0))
            {
                validoMN = true;
                error3.Visible = false;
            }
            else
            {
                validoMN = false;
                error3.Visible = true;
            }

            if((cantColoresJ1 >0) & (cantColoresJ1 <= 5))
            {
                valColores1 = true;
                error1.Visible = false;
            }
            else
            {
                valColores1 = false;
                error1.Visible = true;
            }

            if((cantColoresJ2 > 0)&(cantColoresJ2 <= 5))
            {
                valColores2 = true;
                error2.Visible = false;
            }
            else
            {
                valColores2 = false;
                error2.Visible = true;
            }

            if((validoMN == true) & (valColores1 == true) & (valColores2 == true))
            {
                WebForm7.columnas = columnas;
                WebForm7.filas = filas;
                Response.Redirect("TableroOX.aspx");
            }

        }

        protected void negro1_CheckedChanged(object sender, EventArgs e)
        {
            if(negro1.Checked == true)
            {
                cantColoresJ1 += 1;
                negro2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void blanco1_CheckedChanged(object sender, EventArgs e)
        {
            if (blanco1.Checked == true)
            {
                cantColoresJ1 += 1;
                blanco2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void aleatorio1_CheckedChanged(object sender, EventArgs e)
        {
            if (celeste1.Checked == true)
            {
                cantColoresJ1 += 1;
                celeste2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void gris1_CheckedChanged(object sender, EventArgs e)
        {
            if (gris1.Checked == true)
            {
                cantColoresJ1 += 1;
                gris2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void violeta1_CheckedChanged(object sender, EventArgs e)
        {
            if (violeta1.Checked == true)
            {
                cantColoresJ1 += 1;
                violeta2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void verde1_CheckedChanged(object sender, EventArgs e)
        {
            if (verde1.Checked == true)
            {
                cantColoresJ1 += 1;
                verde2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void naranja1_CheckedChanged(object sender, EventArgs e)
        {
            if (naranja1.Checked == true)
            {
                cantColoresJ1 += 1;
                neranja2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void azul1_CheckedChanged(object sender, EventArgs e)
        {
            if (azul1.Checked == true)
            {
                cantColoresJ1 += 1;
                azul2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void amarillo1_CheckedChanged(object sender, EventArgs e)
        {
            if (amarillo1.Checked == true)
            {
                cantColoresJ1 += 1;
                amarillo2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void rojo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rojo1.Checked == true)
            {
                cantColoresJ1 += 1;
                rojo2.Checked = false;
            }
            else
            {
                cantColoresJ1 -= 1;
            }
        }

        protected void negro2_CheckedChanged(object sender, EventArgs e)
        {
            if (negro2.Checked == true)
            {
                cantColoresJ2 += 1;
                negro1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void blanco2_CheckedChanged(object sender, EventArgs e)
        {
            if (blanco2.Checked == true)
            {
                cantColoresJ2 += 1;
                blanco1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void celeste2_CheckedChanged(object sender, EventArgs e)
        {
            if (celeste2.Checked == true)
            {
                cantColoresJ2 += 1;
                celeste1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void gris2_CheckedChanged(object sender, EventArgs e)
        {
            if (gris2.Checked == true)
            {
                cantColoresJ2 += 1;
                gris1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void violeta2_CheckedChanged(object sender, EventArgs e)
        {
            if (violeta2.Checked == true)
            {
                cantColoresJ2 += 1;
                violeta1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void verde2_CheckedChanged(object sender, EventArgs e)
        {
            if (verde2.Checked == true)
            {
                cantColoresJ2 += 1;
                verde1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void neranja2_CheckedChanged(object sender, EventArgs e)
        {
            if (neranja2.Checked == true)
            {
                cantColoresJ2 += 1;
                naranja1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void azul2_CheckedChanged(object sender, EventArgs e)
        {
            if (azul2.Checked == true)
            {
                cantColoresJ2 += 1;
                azul1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void amarillo2_CheckedChanged(object sender, EventArgs e)
        {
            if (amarillo2.Checked == true)
            {
                cantColoresJ2 += 1;
                amarillo1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
            }
        }

        protected void rojo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rojo2.Checked == true)
            {
                cantColoresJ2 += 1;
                rojo1.Checked = false;
            }
            else
            {
                cantColoresJ2 -= 1;
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

        protected void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreJ2.Text = listaUsuarios.SelectedValue;
        }

        protected void nombreNR_TextChanged(object sender, EventArgs e)
        {
            nombreJ2.Text = nombreNR.Text;
        }
    }
}