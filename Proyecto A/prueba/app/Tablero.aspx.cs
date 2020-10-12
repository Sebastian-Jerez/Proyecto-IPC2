using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public static Boolean tiroValido = false;
        public static Boolean up = false;
        public static Boolean down = false;
        public static Boolean derecha = false;
        public static Boolean izquierda = false;
        public static Boolean ddup = false;
        public static Boolean dddown = false;
        public static Boolean diup = false;
        public static Boolean didown = false;
        public static int movidasJ1 = 0;
        public static int movidasJ2 = 0;
        public static int cantFBlancas = 0;
        public static int cantFNegras = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TI.Visible = false;
            }
            if (WebForm5.estado == 1)
            {
                WebForm5.estado = 2;
                nomJ1.Text = WebForm5.valJ1;
                nomJ2.Text = WebForm5.valJ2;
                if (WebForm5.colorJ1 == "black")
                {
                    cajaC.BackColor = Color.Black;
                    cajaC.ForeColor = Color.Black;
                    cajaC2.BackColor = Color.White;
                    cajaC2.ForeColor = Color.White;

                    if(WebForm5.turnoJ == 1)
                    {
                        turno = true;
                        valuarT();
                    }
                    else
                    {
                        turno = false;
                        valuarT();
                    }

                }
                else
                {
                    cajaC.BackColor = Color.White;
                    cajaC.ForeColor = Color.White;
                    cajaC2.BackColor = Color.Black;
                    cajaC2.ForeColor = Color.Black;

                    if (WebForm5.turnoJ == 1)
                    {
                        turno = false;
                        valuarT();
                    }
                    else
                    {
                        turno = true;
                        valuarT();
                    }
                }
            }

            if(WebForm2.carga == 1)
            {
                cargaXml();
                WebForm2.carga = 2;
                
            }
        }

        public void valuarT()
        {
            if (turno == true)
            {
                if (WebForm5.colorJ1 == "black")
                {
                    turnoC1.Visible = true;
                    turnoC2.Visible = false;
                }
                else
                {
                    turnoC1.Visible = false;
                    turnoC2.Visible = true;
                }
            }
            else
            {
                if (WebForm5.colorJ1 == "black")
                {
                    turnoC1.Visible = false;
                    turnoC2.Visible = true;
                }
                else
                {
                    turnoC1.Visible = true;
                    turnoC2.Visible = false;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }

        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    e3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }
               
                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                
                valuarT();
            }
            
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string c = "b";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                
                valuarT();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                
                valuarT();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    e1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                
                valuarT();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "1";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h1.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h1.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    e2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {

            string c = "f";
            string f = "2";
            valitarTiro(c, f);
            if (turno == true)
            {
                if(tiroValido == true)
                {
                    f2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }
           
                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "2";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h2.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h2.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "3";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h3.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h3.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "6";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button42_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "6";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "6";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "6";
            valitarTiro(c, f);
            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "6";
            valitarTiro(c, f);
            if (turno == true)
            {
                if(tiroValido == true)
                {
                    e6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "6";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button47_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "6";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button48_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "6";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h6.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h6.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button49_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button50_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button51_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button52_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button53_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "7";
            valitarTiro(c, f);
            if (turno == true)
            {
                if(tiroValido == true)
                {
                    e7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }
                
                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button54_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button55_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button56_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "7";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h7.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h7.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button57_Click(object sender, EventArgs e)
        {
            string c = "a";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    a8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    a8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button58_Click(object sender, EventArgs e)
        {
            string c = "b";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    b8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    b8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button59_Click(object sender, EventArgs e)
        {
            string c = "c";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    c8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    c8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button60_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button61_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    e8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button62_Click(object sender, EventArgs e)
        {
            string c = "f";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    f8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    f8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button63_Click(object sender, EventArgs e)
        {
            string c = "g";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    g8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    g8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void Button64_Click(object sender, EventArgs e)
        {
            string c = "h";
            string f = "8";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    h8.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    h8.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }

        }

        protected void d4_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
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
                string idD = "d" + i.ToString();
                string idE = "e" + i.ToString();
                string idF = "f" + i.ToString();
                string idG = "g" + i.ToString();
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

        public void cargaXml()
        {
            string colorf = "";
            string columna = "";
            string fila = "";
            string ficha = "";
            int val = 0;

            using (XmlTextReader xmlReader = new XmlTextReader(@"C:\Users\tataj\OneDrive\Documents\Mis Documentos\Universidad\USAC\4to Semestre\IPC2\Laboratorio\Proyecto\docXtml\tablero.xml"))
            {
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "ficha"))
                    {
                        val += 1;
                    }
                }
            }


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\tataj\OneDrive\Documents\Mis Documentos\Universidad\USAC\4to Semestre\IPC2\Laboratorio\Proyecto\docXtml\tablero.xml");
            for (int i = 0; i <val; i++)
            {
                foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[i].ChildNodes)
                {
                    if (xmlNode.Name.Equals("color"))
                    {
                        colorf = xmlNode.InnerText;
                    }
                    else if (xmlNode.Name.Equals("columna"))
                    {
                        columna = xmlNode.InnerText;
                    }
                    else if (xmlNode.Name.Equals("fila"))
                    {
                        fila = xmlNode.InnerText;
                    }
                }
                string columnaF = columna.ToLower();
                ficha = columnaF + fila;
                Button Nid = FindControl(ficha) as Button;
                if (colorf.Equals("negro"))
                {
                    //a1.BackColor = System.Drawing.Color.White;
                    Nid.BackColor = System.Drawing.Color.Black;
                }
                else if (colorf.Equals("blanco"))
                {
                    //a1.BackColor = System.Drawing.Color.White;
                    Nid.BackColor = System.Drawing.Color.White;
                }
            }
            
        }

        public void valitarTiro(string columna, string fila)
        {
            string posA = columna + fila;
            Button btA = FindControl(posA) as Button;
            if ((btA.BackColor != Color.Black) & (btA.BackColor != Color.White))
            {
                if ((encontradoUp(columna, fila) == true) || (encontradoDown(columna, fila) == true) || (encontradoDerecha(columna, fila) == true) || (encontradoIzquierda(columna, fila) == true)
                    || (encontradoDDUp(columna, fila) == true) || (encontradoDDDown(columna, fila) == true) || (encontradoDIUp(columna, fila) == true) || (encontradoDIDown(columna, fila) == true))
                {
                    encerrado(columna, fila);
                }
                else
                {
                    tiroValido = false;
                }
            }
            else
            {
                tiroValido = false;
            }
        }

        public int valorColumna(string letraC)
        {
            int valC = 0;

            if (letraC == "a")
            {
                return valC = 1;
            }
            else if(letraC == "b")
            {
                return valC = 2;
            }
            else if (letraC == "c")
            {
                return valC = 3;
            }
            else if (letraC == "d")
            {
                return valC = 4;
            }
            else if (letraC == "e")
            {
                return valC = 5;
            }
            else if (letraC == "f")
            {
                return valC = 6;
            }
            else if (letraC == "g")
            {
                return valC = 7;
            }
            else if (letraC == "h")
            {
                return valC = 8;
            }
            else
            {
                return valC;
            }
        }

        public string letraColumna(int valorC)
        {
            string letC = "";

            if (valorC == 1)
            {
                return letC = "a";
            }
            else if (valorC == 2)
            {
                return letC = "b";
            }
            else if (valorC == 3)
            {
                return letC = "c";
            }
            else if (valorC == 4)
            {
                return letC = "d";
            }
            else if (valorC == 5)
            {
                return letC = "e";
            }
            else if (valorC == 6)
            {
                return letC = "f";
            }
            else if (valorC == 7)
            {
                return letC = "g";
            }
            else if (valorC == 8)
            {
                return letC = "h";
            }
            else
            {
                return letC;
            }
        }

        public Boolean encontradoUp(string col, string fil)
        {

            Boolean siEsta = true;
            string x = col;
            int y = (Int32.Parse(fil) - 1);
            if(y > 0)
            {
                string idE = x + (y.ToString());
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                
            }
            else
            {
                return siEsta = false;
            }
            
        }

        public Boolean encontradoDown(string col, string fil)
        {

            Boolean siEsta = true;
            string x = col;
            int y = (Int32.Parse(fil) + 1);
            if (y < 9)
            {
                string idE = x + (y.ToString());
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public Boolean encontradoDerecha(string col, string fil)
        {

            Boolean siEsta = true;
            int columnaTemp = (valorColumna(col)+1);
            string y = fil;
            if (columnaTemp < 9)
            {
                string x = letraColumna(columnaTemp);
                string idE = x + y;
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public Boolean encontradoIzquierda(string col, string fil)
        {

            Boolean siEsta = true;
            int columnaTemp = (valorColumna(col) - 1);
            string y = fil;
            if (columnaTemp > 0)
            {
                string x = letraColumna(columnaTemp);
                string idE = x + y;
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public Boolean encontradoDDUp(string col, string fil)
        {
            Boolean siEsta = true;
            int columnaTemp = (valorColumna(col) + 1);
            int y = (Int32.Parse(fil) - 1);
            if ((columnaTemp < 9) & (y > 0))
            {
                string x = letraColumna(columnaTemp);
                string idE = x + y.ToString();
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public Boolean encontradoDDDown(string col, string fil)
        {
            Boolean siEsta = true;
            int columnaTemp = (valorColumna(col) + 1);
            int y = (Int32.Parse(fil) + 1);
            if ((columnaTemp < 9) & (y < 9))
            {
                string x = letraColumna(columnaTemp);
                string idE = x + y.ToString();
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public Boolean encontradoDIUp(string col, string fil)
        {
            Boolean siEsta = true;
            int columnaTemp = (valorColumna(col) - 1);
            int y = (Int32.Parse(fil) - 1);
            if ((columnaTemp > 0) & (y > 0))
            {
                string x = letraColumna(columnaTemp);
                string idE = x + y.ToString();
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public Boolean encontradoDIDown(string col, string fil)
        {
            Boolean siEsta = true;
            int columnaTemp = (valorColumna(col) - 1);
            int y = (Int32.Parse(fil) + 1);
            if ((columnaTemp > 0) & (y < 9))
            {
                string x = letraColumna(columnaTemp);
                string idE = x + y.ToString();
                Button btE = FindControl(idE) as Button;
                if (turno == true)
                {
                    if (btE.BackColor == Color.White)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }
                else
                {
                    if (btE.BackColor == Color.Black)
                    {
                        return siEsta = true;
                    }
                    else
                    {
                        return siEsta = false;
                    }
                }

            }
            else
            {
                return siEsta = false;
            }

        }

        public void encerrado(string col, string fil)
        {
            //validar si hay una pieza encerrada
            for (int i =0; i < 8; i++)
            {
                if(i == 0)
                {
                    if (encontradoUp(col, fil) == true)
                    {
                        string x = col;
                        int y = (Int32.Parse(fil) - 1);
                        while (y > 0)
                        {
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            y = y - 1;
                        }
                         
                        if(tiroValido == true) 
                        {
                            break;
                        }
                    }
                }
                else if(i == 1)
                {
                    if (encontradoDown(col, fil) == true)
                    {
                        string x = col;
                        int y = (Int32.Parse(fil) + 1);
                        while (y < 9)
                        {
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            y = y + 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else if(i == 2)
                {
                    if (encontradoDerecha(col, fil) == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        string y = fil;
                        while (co < 9)
                        {
                            x = letraColumna(co);
                            string idE = x + y;
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            co = co + 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else if(i == 3)
                {
                    if (encontradoIzquierda(col, fil) == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        string y = fil;
                        while (co > 0)
                        {
                            x = letraColumna(co);
                            string idE = x + y;
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            co = co - 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else if (i == 4)
                {
                    if (encontradoDDUp(col, fil) == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        int y = (Int32.Parse(fil) - 1);
                        while ((co < 9) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            co = co + 1;
                            y = y - 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else if (i == 5)
                {
                    if (encontradoDDDown(col, fil) == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        int y = (Int32.Parse(fil) + 1);
                        while ((co < 9) & (y < 9))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            co = co + 1;
                            y = y + 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else if (i == 6)
                {
                    if (encontradoDIUp(col, fil) == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        int y = (Int32.Parse(fil) - 1);
                        while ((co > 0) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            co = co - 1;
                            y = y - 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else if (i == 7)
                {
                    if (encontradoDIDown(col, fil) == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        int y = (Int32.Parse(fil) + 1);
                        while ((co > 0) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        tiroValido = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                tiroValido = false;
                                break;
                            }
                            co = co - 1;
                            y = y + 1;
                        }

                        if (tiroValido == true)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    tiroValido = false;
                }
            }

            //Validar en que direcciones se está encerrando
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    if (encontradoUp(col, fil) == true)
                    {
                        string x = col;
                        int y = (Int32.Parse(fil) - 1);
                        while (y > 0)
                        {
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        up = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        up = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                up = false;
                                break;
                            }
                            y = y - 1;
                        }
                    }
                }
                else if (i == 1)
                {
                    if (encontradoDown(col, fil) == true)
                    {
                        string x = col;
                        int y = (Int32.Parse(fil) + 1);
                        while (y < 9)
                        {
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        down = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        down = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                down = false;
                                break;
                            }
                            y = y + 1;
                        }
                    }
                }
                else if (i == 2)
                {
                    if (encontradoDerecha(col, fil) == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        string y = fil;
                        while (co < 9)
                        {
                            x = letraColumna(co);
                            string idE = x + y;
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        derecha = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        derecha = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                derecha = false;
                                break;
                            }
                            co = co + 1;
                        }
                    }
                }
                else if (i == 3)
                {
                    if (encontradoIzquierda(col, fil) == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        string y = fil;
                        while (co > 0)
                        {
                            x = letraColumna(co);
                            string idE = x + y;
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        izquierda = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        izquierda = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                izquierda = false;
                                break;
                            }
                            co = co - 1;
                        }
                    }
                }
                else if (i == 4)
                {
                    if (encontradoDDUp(col, fil) == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        int y = (Int32.Parse(fil) - 1);
                        while ((co < 9) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        ddup = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        ddup = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                ddup = false;
                                break;
                            }
                            co = co + 1;
                            y = y - 1;
                        }
                    }
                }
                else if (i == 5)
                {
                    if (encontradoDDDown(col, fil) == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        int y = (Int32.Parse(fil) + 1);
                        while ((co < 9) & (y < 9))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        dddown = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        dddown = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                dddown = false;
                                break;
                            }
                            co = co + 1;
                            y = y + 1;
                        }
                    }
                }
                else if (i == 6)
                {
                    if (encontradoDIUp(col, fil) == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        int y = (Int32.Parse(fil) - 1);
                        while ((co > 0) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        diup = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        diup = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                diup = false;
                                break;
                            }
                            co = co - 1;
                            y = y - 1;
                        }
                    }
                }
                else if (i == 7)
                {
                    if (encontradoDIDown(col, fil) == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        int y = (Int32.Parse(fil) + 1);
                        while ((co > 0) & (y < 9))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        didown = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        didown = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                didown = false;
                                break;
                            }
                            co = co - 1;
                            y = y + 1;
                        }
                    }
                }
                else
                {
                    int val =0;
                }
            }
        }

        public void pintarFE(string col, string fil)
        {

            for (int i =0; i<9; i++)
            {
                if(i == 0)
                {
                    if (up == true)
                    {
                        string x = col;
                        int y = (Int32.Parse(fil) - 1);
                        while (y > 0)
                        {
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            y = y - 1;
                        }
                    }
                }
                else if(i == 1)
                {
                    if(down == true)
                    {
                        string x = col;
                        int y = (Int32.Parse(fil) + 1);
                        while (y < 9)
                        {
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            y = y + 1;
                        }
                    }
                }
                else if(i == 2)
                {
                    if (derecha == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        string y = fil;
                        while (co < 9)
                        {
                            x = letraColumna(co);
                            string idE = x + y;
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            co = co + 1;
                        }
                    }
                }
                else if(i == 3)
                {
                    if (izquierda == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        string y = fil;
                        while (co > 0)
                        {
                            x = letraColumna(co);
                            string idE = x + y;
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            co = co - 1;
                        }
                    }
                }
                else if(i == 4)
                {
                    if (ddup == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        int y = (Int32.Parse(fil) - 1);
                        while ((co < 9) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            co = co + 1;
                            y = y - 1;
                        }
                    }
                }
                else if(i == 5)
                {
                    if (dddown == true)
                    {
                        int co = (valorColumna(col) + 1);
                        string x;
                        int y = (Int32.Parse(fil) + 1);
                        while ((co < 9) & (y < 9))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            co = co + 1;
                            y = y + 1;
                        }
                    }
                }
                else if(i == 6)
                {
                    if (diup == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        int y = (Int32.Parse(fil) - 1);
                        while ((co > 0) & (y > 0))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            co = co - 1;
                            y = y - 1;
                        }
                    }
                }
                else if (i == 7)
                {
                    if(didown == true)
                    {
                        int co = (valorColumna(col) - 1);
                        string x;
                        int y = (Int32.Parse(fil) + 1);
                        while ((co > 0) & (y <9))
                        {
                            x = letraColumna(co);
                            string idE = x + y.ToString();
                            Button btE = FindControl(idE) as Button;
                            if ((btE.BackColor == Color.White) || (btE.BackColor == Color.Black))
                            {
                                if (turno == true)
                                {
                                    if ((btE.BackColor == Color.Black))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    if ((btE.BackColor == Color.White))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        btE.BackColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                            co = co - 1;
                            y = y + 1;
                        }
                    }
                }
            }
        }

        public void conteoFichas()
        {
            //Recorre las columnas
            for(int i = 1; i<=8; i++)
            {
                //Recorre las filas
                for (int f = 1; f <= 8; f++)
                {
                    string columna = letraColumna(i);
                    string fila = f.ToString();
                    string idaE = columna + fila;
                    Button btaE = FindControl(idaE) as Button;

                    if(btaE.BackColor == Color.Black)
                    {
                        cantFNegras += 1;
                    }
                    else if(btaE.BackColor == Color.White)
                    {
                        cantFBlancas += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        protected void e4_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "4";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    e4.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e4.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void d5_Click(object sender, EventArgs e)
        {
            string c = "d";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    d5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    d5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }

        protected void e5_Click(object sender, EventArgs e)
        {
            string c = "e";
            string f = "5";
            valitarTiro(c, f);

            if (turno == true)
            {
                if (tiroValido == true)
                {
                    e5.BackColor = System.Drawing.Color.Black;
                    pintarFE(c, f);
                    turno = false;
                }
                else
                {
                    TI.Visible = true;
                }

                valuarT();
            }
            else if (turno == false)
            {
                if (tiroValido == true)
                {
                    e5.BackColor = System.Drawing.Color.White;
                    pintarFE(c, f);
                    turno = true;
                }
                else
                {
                    TI.Visible = true;
                }
                valuarT();
            }
        }
    }
}