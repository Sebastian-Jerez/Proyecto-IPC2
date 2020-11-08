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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pais.DataSource = Pais();
            pais.DataBind();
            pais.Items.Insert(0, "Seleccione...");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-LAS89DVA;Initial Catalog=registroU;Integrated Security=True"))
            {
                string nombre = nombreU.Text;
                string apellido = apellidoU.Text;
                string usuario = user.Text;
                string contra = passU.Text;
                string fecha = fnac.Text;
                string pa = pais.SelectedValue;
                string corr = correo.Text;
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("insert into USUARIO (NombreUsuario, Contrasenia, NombrePersonal, ApellidoPersonal, FechaNac, Pais, Correo_e) values('" + usuario + "','" + contra + "','" + nombre + "','" + apellido + "','" + fecha + "','" + pa + "','" + corr + "' )", sqlCon);
                DataTable dtb = new DataTable();
                sqlDa.Fill(dtb);
                sqlCon.Close();

            }

            Response.Write("Usuario registrado con éxito!");
            Response.Redirect("PantallaP.aspx");
        }

        protected void pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<string> Pais()
        {
            List<string> Paises = new List<string>();
            foreach (CultureInfo informacion in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo nombre = new RegionInfo(informacion.LCID);
                if (!Paises.Contains(nombre.EnglishName))
                {
                    Paises.Add(nombre.EnglishName);
                    Paises.Sort();
                }
            }
            return Paises;
        }

    }
}