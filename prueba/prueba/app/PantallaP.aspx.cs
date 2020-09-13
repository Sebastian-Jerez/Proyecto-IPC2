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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginU.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tablero.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            string color = "";
            string columna = "";
            string fila = "";
            string ficha = "";

            XmlTextReader xmlReader = new XmlTextReader(@"C:\Users\tataj\OneDrive\Documents\Mis Documentos\Universidad\USAC\4to Semestre\IPC2\Laboratorio\Proyecto\docXtml");

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "color"))
                {
                    if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        color = xmlReader.ReadContentAsString();
                    }
                    
                }

                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "columna"))
                {
                    if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        columna = xmlReader.ReadContentAsString();
                    }
                }

                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "fila"))
                {
                    if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        fila = xmlReader.ReadContentAsString();
                    }
                }

                ficha += columna + fila;
                Button Nid = FindControl(ficha) as Button;
                Nid.BackColor.Equals(color);
            }
        }
    }
}