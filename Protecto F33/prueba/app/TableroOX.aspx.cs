using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace prueba.app
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        //Listas de colores para cada jugador
        public static List<string> coloresJ1 = new List<string>();
        public static List<string> coloresJ2 = new List<string>();

        //Variables para tablero
        public static int columnas;
        public static int filas;
        public static Ficha[,] tablero;
        public static Ficha fichaN;

        //Variables extra
        public static int cont = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                tableroN(filas, columnas);
                cont = 1;
            }

            if( cont >=1)
            {
                mostrarT(filas, columnas);
            }
        }

        public void tableroN (int fila, int columna)
        {

            tablero = new Ficha[fila, columna];

            for(int i = 0; i<fila; i++)
            {
                for(int j = 0; j<columna; j++)
                {
                    string letraC = letraColumna(j);
                    string idBoton = letraC + Convert.ToInt32(i);
                    fichaN = new Ficha();
                    fichaN.setCol(j);
                    fichaN.setFil(i);
                    fichaN.setidB(idBoton);
                    fichaN.CssClass = "ficha";
                    tablero[i, j] = fichaN;
                   
                }
            }

            mostrarT(fila, columna);
            
        }

        public void mostrarT(int fila, int columna)
        {
            HtmlGenericControl htmlC = new HtmlGenericControl("div");

            htmlC.Attributes.Add("runat", "server");
            htmlC.Attributes["style"] = "width:" + ((100 * columna)).ToString() + "px; height:" + ((100 * fila)-150) + "px;";

            Page.Form.Controls.Add(htmlC);

            HtmlGenericControl htmlN;
            for(int i = 0; i<fila; i++)
            {
                for(int j = 0; j<columna; j++)
                {
                    htmlN = new HtmlGenericControl("div");
                    tablero[i, j].Click += new EventHandler(eventoF);
                    htmlN.Attributes.Add("runat", "server");
                    htmlN.Attributes["class"] = "celda";
                    htmlN.Controls.Add(tablero[i, j]);

                    htmlC.Controls.Add(htmlN);
                }
            }

            Page.Form.Controls.Add(htmlC);
        }

        public class Ficha : System.Web.UI.WebControls.Button
        {
            int colum;
            int fil;
            string idB;
            string color;

            public void setCol(int columna)
            {
                colum = columna;
            }

            public int getCol()
            {
                return colum;
            }

            public void setFil(int fila)
            {
                fil = fila;
            }

            public int getFil()
            {
                return fil;
            }

            public void setidB(string idboton)
            {
                idB = idboton;
            }

            public string getidB()
            {
                return idB;
            }

            public void setColor(string colorF)
            {
                color = colorF;
            }

            public string getColor()
            {
                return color;
            }

        }

        private void eventoF (object sender, EventArgs e)
        {
            Ficha eFicha = (Ficha)sender;
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
            else if (valorC == 9)
            {
                return letC = "i";
            }
            else if (valorC == 10)
            {
                return letC = "j";
            }
            else if (valorC == 11)
            {
                return letC = "k";
            }
            else if (valorC == 12)
            {
                return letC = "l";
            }
            else if (valorC == 13)
            {
                return letC = "m";
            }
            else if (valorC == 14)
            {
                return letC = "n";
            }
            else if (valorC == 15)
            {
                return letC = "o";
            }
            else if (valorC == 16)
            {
                return letC = "p";
            }
            else if (valorC == 17)
            {
                return letC = "q";
            }
            else if (valorC == 18)
            {
                return letC = "r";
            }
            else if (valorC == 19)
            {
                return letC = "s";
            }
            else if (valorC == 20)
            {
                return letC = "t";
            }
            else if (valorC == 21)
            {
                return letC = "w";
            }
            else
            {
                return letC;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}