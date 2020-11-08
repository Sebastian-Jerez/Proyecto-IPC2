using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public static int UCU = 0;
        public static int Maquina = 0;
        public static string nombreArchivo = "";

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
            UCU = 1;
            Response.Redirect("DatosPartidaUcU.aspx?nomj=" + nomU.Text);
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            nomA.Visible = true;
            aceptar.Visible = true; 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maquina = 1;
            Response.Redirect("DatosPartidaUcU.aspx?nomj=" + nomU.Text);

        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            carga = 1;
            nombreArchivo = nomA.Text;
            Response.Redirect("Tablero.aspx");
        }

        protected void OX_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosXT.aspx?nomj=" + nomU.Text);
        }

        protected void pu_Click(object sender, EventArgs e)
        {
            string cons = "Data Source=LAPTOP-LAS89DVA;Initial Catalog=registroU;Integrated Security=True";
            SqlConnection conec = new SqlConnection(cons);
            conec.Open();
            SqlCommand comando = new SqlCommand("Select * FROM USUARIO WHERE NombreUsuario = @nomU", conec);
            comando.Parameters.AddWithValue("@nomU", nomU.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                WebForm9.name = registro["NombrePersonal"].ToString();
                WebForm9.ape = registro["ApellidoPersonal"].ToString();
                WebForm9.nameU = registro["NombreUsuario"].ToString();
                WebForm9.mailU = registro["Correo_e"].ToString();
                WebForm9.fechaN = registro["FechaNac"].ToString();
                WebForm9.paisU = registro["Pais"].ToString();
            }
            string iduser = registro["IdUsuario"].ToString();
            conec.Close();

            conec.Open();
            SqlCommand comando2 = new SqlCommand("Select * FROM REPORTE WHERE IdUsuarios = @idU", conec);
            comando2.Parameters.AddWithValue("@idU", iduser);
            SqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                WebForm9.PG = registro2["PGanadas"].ToString();
                WebForm9.PE = registro2["PEmpatadas"].ToString();
                WebForm9.PP = registro2["PPerdidas"].ToString();
            }
            conec.Close();

            conec.Open();
            SqlCommand comando3 = new SqlCommand("Select * FROM REPORTET WHERE IdUsuarios = @idU", conec);
            comando3.Parameters.AddWithValue("@idU", iduser);
            SqlDataReader registro3 = comando3.ExecuteReader();
            if (registro3.Read())
            {
                WebForm9.TG = registro3["TorneosGanados"].ToString();
                WebForm9.TP = registro3["TorneosPar"].ToString();
                WebForm9.PT = registro3["PuntosTorneos"].ToString();
            }


            conec.Close();
            Response.Redirect("PerfilUsuario.aspx");

        }
    }
}