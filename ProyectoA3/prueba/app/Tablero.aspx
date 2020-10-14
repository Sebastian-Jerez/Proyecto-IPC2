<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablero.aspx.cs" Inherits="prueba.app.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StyleT.css" type="text/css" media="screen">
    <title></title>
    <style type="text/css">
        #jugador1 {
            height: 250px;
        }
        #jugador2 {
            height: 251px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <h1>
        <asp:Label ID="Label1" runat="server" Text="Partida"></asp:Label>
            
        </h1>
    </header>
      <div id ="principal">
        <div id="col">
            <div class="letraC">
                <asp:Label ID="Label2" runat="server" Text="A"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label3" runat="server" Text="B"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label4" runat="server" Text="C"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label5" runat="server" Text="D"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label6" runat="server" Text="E"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label7" runat="server" Text="F"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label8" runat="server" Text="G"></asp:Label>
            </div>
            <div class="letraC">
                <asp:Label ID="Label9" runat="server" Text="H"></asp:Label>
            </div>
        </div>
        <div id="fil">
            <div class="letraF">
                <br />
                1<br />
            </div>
            <div class="letraF">
                <br />
                2</div>
            <div class="letraF">
                <br />
                <br />
                3</div>
            <div class="letraF">
                <br />
                <br />
                4<br />
            </div>
            <div class="letraF">
                <br />
                <br />
                5</div>
            <div class="letraF">
                <br />
                <br />
                6</div>
            <div class="letraF">
                <br />
                <br />
                7</div>
            <div class="letraF">
                <br />
                <br />
                8</div>
        </div>
          <br />
          <div id="jugadores">
              <div id="jugador1" class="datoJ">
                  <asp:Label ID="tituloJ1" runat="server" Text="Jugador #1"></asp:Label>
                  <br />
                  <br />
                  <asp:Label ID="nomJ1" runat="server" Text="Label"></asp:Label>
                  <br />
                  <br />
                  <asp:Label ID="colorJ1" runat="server" Text="Color: " CssClass="datJ"></asp:Label>
                  <asp:Label ID="cajaC" runat="server" Text="sdff"></asp:Label>
                  <br />
                  <br />
                  <asp:Label ID="turno1" runat="server" Text="Turno:" CssClass="datJ"></asp:Label>
                  <asp:Label ID="turnoC1" runat="server" Text="ssss" CssClass="vos"></asp:Label>
              </div>
              <div id="jugador2" class="datoJ">
                  <asp:Label ID="tituloJ2" runat="server" Text="Jugador #2"></asp:Label>
                  <br />
                  <br />
                  <asp:Label ID="nomJ2" runat="server" Text="Label"></asp:Label>
                  <br />
                  <br />
                  <asp:Label ID="colorJ2" runat="server" Text="Color: " CssClass="datJ"></asp:Label>
                  <asp:Label ID="cajaC2" runat="server" Text="sdff"></asp:Label>
                  <br />
                  <br />
                  <asp:Label ID="turno2" runat="server" Text="Turno:" CssClass="datJ"></asp:Label>
                  <asp:Label ID="turnoC2" runat="server" Text="ssss" CssClass="vos"></asp:Label>
              </div>
              
          </div>
        <div id="tablero">
            <div class="celda" id="A1">

            <asp:Button ID="a1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button1_Click" />

        </div>

        <div class="celda" id="B1">

            <asp:Button ID="b1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button2_Click1" />

        </div>

        <div class="celda" id="C1">

            <asp:Button ID="c1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button3_Click" />

        </div>

        <div class="celda" id="D1">

            <asp:Button ID="d1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button4_Click" />

        </div>

        <div class="celda" id="E1">

            <asp:Button ID="e1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button5_Click" />

        </div>

        <div class="celda" id="F1">

            <asp:Button ID="f1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button6_Click" />

        </div>

        <div class="celda" id="G1">

            <asp:Button ID="g1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button7_Click" />

        </div>

        <div class="celda" id="H1">

            <asp:Button ID="h1" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button8_Click" />

        </div>

        <div class="celda" id="A2">

            <asp:Button ID="a2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button9_Click" />

        </div>

        <div class="celda" id="B2">

            <asp:Button ID="b2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button10_Click" />

        </div>

        <div class="celda" id="C2">

            <asp:Button ID="c2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button11_Click" />

        </div>

        <div class="celda" id="D2">

            <asp:Button ID="d2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button12_Click" />

        </div>

        <div class="celda" id="E2">

            <asp:Button ID="e2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button13_Click" />

        </div>

        <div class="celda" id="F2">

            <asp:Button ID="f2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button14_Click" />

        </div>

        <div class="celda" id="G2">

            <asp:Button ID="g2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button15_Click" />

        </div>

        <div class="celda" id="H2">

            <asp:Button ID="h2" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button16_Click" />

        </div>

        <div class="celda" id="A3">

            <asp:Button ID="a3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button17_Click" />

        </div>

        <div class="celda" id="B3">

            <asp:Button ID="b3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button18_Click" />

        </div>

        <div class="celda" id="C3">

            <asp:Button ID="c3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button19_Click" />

        </div>

        <div class="celda" id="D3">

            <asp:Button ID="d3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button20_Click" />

        </div>

        <div class="celda" id="E3">

            <asp:Button ID="e3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button21_Click" />

        </div>

        <div class="celda" id="F3">

            <asp:Button ID="f3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button22_Click" />

        </div>  

        <div class="celda" id="G3">

            <asp:Button ID="g3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button23_Click" />

        </div>

        <div class="celda" id="H3">

            <asp:Button ID="h3" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button24_Click" />

        </div>

        <div class="celda" id="A4">

            <asp:Button ID="a4" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button25_Click" />

        </div>

        <div class="celda" id="B4">

            <asp:Button ID="b4" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button26_Click" />

        </div>

        <div class="celda" id="C4">

            <asp:Button ID="c4" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button27_Click" />

        </div>

        <div class="celda" id="D4">

            <asp:Button ID="d4" CssClass="ficha" runat="server" BackColor="white" Height="50px" Width="50px" OnClick="d4_Click" />

        </div>

        <div class="celda" id="E4">

            <asp:Button ID="e4" CssClass="ficha" runat="server" BackColor="black" Height="50px" Width="50px" OnClick="e4_Click" />

        </div>

        <div class="celda" id="F4">

            <asp:Button ID="f4" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button30_Click" />

        </div>

        <div class="celda" id="G4">

            <asp:Button ID="g4" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button31_Click" />

        </div>

        <div class="celda" id="H4">

            <asp:Button ID="h4" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button32_Click" />

        </div>

        <div class="celda" id="A5">

            <asp:Button ID="a5" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button33_Click" />

        </div>

        <div class="celda" id="B5">

            <asp:Button ID="b5" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button34_Click" />

        </div>

        <div class="celda" id="C5">

            <asp:Button ID="c5" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button35_Click" />

        </div>

        <div class="celda" id="D5">

            <asp:Button ID="d5" CssClass="ficha" runat="server" BackColor="black" Height="50px" Width="50px" OnClick="d5_Click" />

        </div>

        <div class="celda" id="E5">

            <asp:Button ID="e5" CssClass="ficha" runat="server" BackColor="white" Height="50px" Width="50px" OnClick="e5_Click" />

        </div>

        <div class="celda" id="F5">

            <asp:Button ID="f5" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button38_Click" />

        </div>

        <div class="celda" id="G5">

            <asp:Button ID="g5" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button39_Click" />

        </div>

        <div class="celda" id="H5">

            <asp:Button ID="h5" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button40_Click" />

        </div>

        <div class="celda" id="A6">

            <asp:Button ID="a6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button41_Click" />

        </div>

        <div class="celda" id="B6">

            <asp:Button ID="b6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button42_Click" />

        </div>

        <div class="celda" id="C6">

            <asp:Button ID="c6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button43_Click" />

        </div>

        <div class="celda" id="D6">

            <asp:Button ID="d6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button44_Click" />

        </div>

        <div class="celda" id="E6">

            <asp:Button ID="e6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button45_Click" />

        </div>

        <div class="celda" id="F6">

            <asp:Button ID="f6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button46_Click" />

        </div>

        <div class="celda" id="G6">

            <asp:Button ID="g6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button47_Click" />

        </div>

        <div class="celda" id="H6">

            <asp:Button ID="h6" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button48_Click" />

        </div>

        <div class="celda" id="A7">

            <asp:Button ID="a7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button49_Click" />

        </div>

        <div class="celda" id="B7">

            <asp:Button ID="b7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button50_Click" />

        </div>

        <div class="celda" id="C7">

            <asp:Button ID="c7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button51_Click" />

        </div>

        <div class="celda" id="D7">

            <asp:Button ID="d7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button52_Click" />

        </div>

        <div class="celda" id="E7">

            <asp:Button ID="e7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button53_Click" />

        </div>
        
        <div class="celda" id="F7">

            <asp:Button ID="f7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button54_Click" />

        </div>

        <div class="celda" id="G7">

            <asp:Button ID="g7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button55_Click" />

        </div>

        <div class="celda" id="H7">

            <asp:Button ID="h7" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button56_Click" />

        </div>

        <div class="celda" id="A8">

            <asp:Button ID="a8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button57_Click" />

        </div>

        <div class="celda" id="B8">

            <asp:Button ID="b8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button58_Click" />

        </div>

        <div class="celda" id="C8">

            <asp:Button ID="c8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button59_Click" />

        </div>

        <div class="celda" id="D8">

            <asp:Button ID="d8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button60_Click" />

        </div>

        <div class="celda" id="E8">

            <asp:Button ID="e8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button61_Click" />

        </div>

        <div class="celda" id="F8">

            <asp:Button ID="f8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button62_Click" />

        </div>

        <div class="celda" id="G8">

            <asp:Button ID="g8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button63_Click" />

        </div>

        <div class="celda" id="H8">

            <asp:Button ID="h8" CssClass="ficha" runat="server" BackColor="Green" Height="50px" Width="50px" OnClick="Button64_Click" />

        </div>
            <br />
        </div>
          
        
          
    </div>
        <asp:Label ID="TI" runat="server" Text="Tiro Inválido"></asp:Label>
        <br />
        <br />
        <div>
        <asp:Button ID="gp" runat="server" Text="Guardar Partida" OnClick="gp_Click" />
        </div>
    </form>
</body>
</html>
