using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace prueba.app
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public static Boolean turno = true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            if (turno == true) {
                c3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c3.BackColor = System.Drawing.Color.White;
                turno = true;
            }

        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                d3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                d3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                e3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                e3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                d1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                d1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                e1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                e1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h1.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h1.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                d2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                d2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                e2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                e2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h2.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h2.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h3.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h3.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a4.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a4.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b4.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b4.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c4.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c4.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f4.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f4.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g4.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g4.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h4.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h4.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a5.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a5.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b5.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b5.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c5.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c5.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f5.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f5.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g5.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g5.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h5.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h5.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button42_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                d6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                d6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                e6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                e6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button47_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button48_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h6.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h6.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button49_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button50_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button51_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button52_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                d7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                d7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button53_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                e7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                e7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button54_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button55_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button56_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h7.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h7.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button57_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                a8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                a8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button58_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                b8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                b8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button59_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                c8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                c8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button60_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                d8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                d8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button61_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                e8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                e8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button62_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                f8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                f8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button63_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                g8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                g8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void Button64_Click(object sender, EventArgs e)
        {
            if (turno == true)
            {
                h8.BackColor = System.Drawing.Color.Black;
                turno = false;
            }
            else if (turno == false)
            {
                h8.BackColor = System.Drawing.Color.White;
                turno = true;
            }
        }

        protected void d4_Click(object sender, EventArgs e)
        {

        }

        protected void gp_Click(object sender, EventArgs e)
        {
            XmlDocument archivo = new XmlDocument();
            XmlElement inicio = archivo.CreateElement("tablero");
            archivo.AppendChild(inicio);

            for (var i = 1; i <= 8; i++)
            {

                string idA = "a" + i.ToString();
                string idB = "b" + i.ToString();
                string idC = "c" + i.ToString();
                string idD = "e" + i.ToString();
                string idE = "f" + i.ToString();
                string idF = "g" + i.ToString();
                string idG = "h" + i.ToString();
                string idH = "h" + i.ToString();

                Button btA = FindControl(idA) as Button;
                Button btB = FindControl(idB) as Button;
                Button btC = FindControl(idC) as Button;
                Button btD = FindControl(idD) as Button;
                Button btE = FindControl(idE) as Button;
                Button btF = FindControl(idF) as Button;
                Button btG = FindControl(idG) as Button;
                Button btH = FindControl(idH) as Button;

                string fcolor;

                a1.BackColor.Equals("Black");

                fcolor = btA.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("A"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("A"));
                    ficha.AppendChild(columna);

                }

                fcolor = btB.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("B"));
                    ficha.AppendChild(columna);

                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("B"));
                    ficha.AppendChild(columna);

                }

                fcolor = btC.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("C"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("C"));
                    ficha.AppendChild(columna);
                }

                fcolor = btD.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("D"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("D"));
                    ficha.AppendChild(columna);
                }

                fcolor = btE.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("E"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("E"));
                    ficha.AppendChild(columna);
                }

                fcolor = btF.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("F"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("F"));
                    ficha.AppendChild(columna);
                }

                fcolor = btG.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("G"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("G"));
                    ficha.AppendChild(columna);
                }

                fcolor = btH.BackColor.Name;
                if (fcolor.Equals("Black"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("negro"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("H"));
                    ficha.AppendChild(columna);
                }
                else if (fcolor.Equals("White"))
                {
                    XmlElement ficha = archivo.CreateElement("ficha");
                    inicio.AppendChild(ficha);

                    XmlElement color = archivo.CreateElement("color");
                    color.AppendChild(archivo.CreateTextNode("blanco"));
                    ficha.AppendChild(color);

                    XmlElement fila = archivo.CreateElement("fila");
                    fila.AppendChild(archivo.CreateTextNode(i.ToString()));
                    ficha.AppendChild(fila);

                    XmlElement columna = archivo.CreateElement("columna");
                    columna.AppendChild(archivo.CreateTextNode("H"));
                    ficha.AppendChild(columna);
                }


                archivo.Save("C:\\Users\\tataj\\OneDrive\\Documents\\Mis Documentos\\Universidad\\USAC\\4to Semestre\\IPC2\\Laboratorio\\Proyecto\\docXtml\\tablero.xml");


                /*IdBoton.backcolor.name*/


            }
        }
    }
}