<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablero.aspx.cs" Inherits="prueba.app.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StyleT.css" type="text/css" media="screen">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <h1>
        <asp:Label ID="Label1" runat="server" Text="Partida"></asp:Label>
        </h1>
    </header>
        <div id="tablero">
            <div class="celda" id="A1">

            <asp:Button ID="Button1" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button1_Click" />

        </div>

        <div class="celda" id="B1">

            <asp:Button ID="Button2" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button2_Click1" />

        </div>

        <div class="celda" id="C1">

            <asp:Button ID="Button3" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button3_Click" />

        </div>

        <div class="celda" id="D1">

            <asp:Button ID="Button4" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button4_Click" />

        </div>

        <div class="celda" id="E1">

            <asp:Button ID="Button5" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button5_Click" />

        </div>

        <div class="celda" id="F1">

            <asp:Button ID="Button6" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button6_Click" />

        </div>

        <div class="celda" id="G1">

            <asp:Button ID="Button7" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button7_Click" />

        </div>

        <div class="celda" id="H1">

            <asp:Button ID="Button8" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button8_Click" />

        </div>

        <div class="celda" id="A2">

            <asp:Button ID="Button9" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button9_Click" />

        </div>

        <div class="celda" id="B2">

            <asp:Button ID="Button10" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button10_Click" />

        </div>

        <div class="celda" id="C2">

            <asp:Button ID="Button11" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button11_Click" />

        </div>

        <div class="celda" id="D2">

            <asp:Button ID="Button12" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button12_Click" />

        </div>

        <div class="celda" id="E2">

            <asp:Button ID="Button13" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button13_Click" />

        </div>

        <div class="celda" id="F2">

            <asp:Button ID="Button14" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button14_Click" />

        </div>

        <div class="celda" id="G2">

            <asp:Button ID="Button15" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button15_Click" />

        </div>

        <div class="celda" id="H2">

            <asp:Button ID="Button16" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button16_Click" />

        </div>

        <div class="celda" id="A3">

            <asp:Button ID="Button17" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button17_Click" />

        </div>

        <div class="celda" id="B3">

            <asp:Button ID="Button18" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button18_Click" />

        </div>

        <div class="celda" id="C3">

            <asp:Button ID="Button19" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button19_Click" />

        </div>

        <div class="celda" id="D3">

            <asp:Button ID="Button20" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button20_Click" />

        </div>

        <div class="celda" id="E3">

            <asp:Button ID="Button21" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button21_Click" />

        </div>

        <div class="celda" id="F3">

            <asp:Button ID="Button22" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button22_Click" />

        </div>  

        <div class="celda" id="G3">

            <asp:Button ID="Button23" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button23_Click" />

        </div>

        <div class="celda" id="H3">

            <asp:Button ID="Button24" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button24_Click" />

        </div>

        <div class="celda" id="A4">

            <asp:Button ID="Button25" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button25_Click" />

        </div>

        <div class="celda" id="B4">

            <asp:Button ID="Button26" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button26_Click" />

        </div>

        <div class="celda" id="C4">

            <asp:Button ID="Button27" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button27_Click" />

        </div>

        <div class="celda" id="D4">

            <asp:Button ID="Button28" CssClass="ficha" runat="server" BackColor="white" Height="50px" Width="50px" />

        </div>

        <div class="celda" id="E4">

            <asp:Button ID="Button29" CssClass="ficha" runat="server" BackColor="black" Height="50px" Width="50px" />

        </div>

        <div class="celda" id="F4">

            <asp:Button ID="Button30" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button30_Click" />

        </div>

        <div class="celda" id="G4">

            <asp:Button ID="Button31" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button31_Click" />

        </div>

        <div class="celda" id="H4">

            <asp:Button ID="Button32" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button32_Click" />

        </div>

        <div class="celda" id="A5">

            <asp:Button ID="Button33" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button33_Click" />

        </div>

        <div class="celda" id="B5">

            <asp:Button ID="Button34" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button34_Click" />

        </div>

        <div class="celda" id="C5">

            <asp:Button ID="Button35" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button35_Click" />

        </div>

        <div class="celda" id="D5">

            <asp:Button ID="Button36" CssClass="ficha" runat="server" BackColor="black" Height="50px" Width="50px" />

        </div>

        <div class="celda" id="E5">

            <asp:Button ID="Button37" CssClass="ficha" runat="server" BackColor="white" Height="50px" Width="50px" />

        </div>

        <div class="celda" id="F5">

            <asp:Button ID="Button38" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button38_Click" />

        </div>

        <div class="celda" id="G5">

            <asp:Button ID="Button39" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button39_Click" />

        </div>

        <div class="celda" id="H5">

            <asp:Button ID="Button40" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button40_Click" />

        </div>

        <div class="celda" id="A6">

            <asp:Button ID="Button41" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button41_Click" />

        </div>

        <div class="celda" id="B6">

            <asp:Button ID="Button42" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button42_Click" />

        </div>

        <div class="celda" id="C6">

            <asp:Button ID="Button43" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button43_Click" />

        </div>

        <div class="celda" id="D6">

            <asp:Button ID="Button44" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button44_Click" />

        </div>

        <div class="celda" id="E6">

            <asp:Button ID="Button45" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button45_Click" />

        </div>

        <div class="celda" id="F6">

            <asp:Button ID="Button46" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button46_Click" />

        </div>

        <div class="celda" id="G6">

            <asp:Button ID="Button47" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button47_Click" />

        </div>

        <div class="celda" id="H6">

            <asp:Button ID="Button48" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button48_Click" />

        </div>

        <div class="celda" id="A7">

            <asp:Button ID="Button49" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button49_Click" />

        </div>

        <div class="celda" id="B7">

            <asp:Button ID="Button50" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button50_Click" />

        </div>

        <div class="celda" id="C7">

            <asp:Button ID="Button51" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button51_Click" />

        </div>

        <div class="celda" id="D7">

            <asp:Button ID="Button52" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button52_Click" />

        </div>

        <div class="celda" id="E7">

            <asp:Button ID="Button53" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button53_Click" />

        </div>
        
        <div class="celda" id="F7">

            <asp:Button ID="Button54" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button54_Click" />

        </div>

        <div class="celda" id="G7">

            <asp:Button ID="Button55" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button55_Click" />

        </div>

        <div class="celda" id="H7">

            <asp:Button ID="Button56" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button56_Click" />

        </div>

        <div class="celda" id="A8">

            <asp:Button ID="Button57" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button57_Click" />

        </div>

        <div class="celda" id="B8">

            <asp:Button ID="Button58" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button58_Click" />

        </div>

        <div class="celda" id="C8">

            <asp:Button ID="Button59" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button59_Click" />

        </div>

        <div class="celda" id="D8">

            <asp:Button ID="Button60" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button60_Click" />

        </div>

        <div class="celda" id="E8">

            <asp:Button ID="Button61" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button61_Click" />

        </div>

        <div class="celda" id="F8">

            <asp:Button ID="Button62" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button62_Click" />

        </div>

        <div class="celda" id="G8">

            <asp:Button ID="Button63" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button63_Click" />

        </div>

        <div class="celda" id="H8">

            <asp:Button ID="Button64" CssClass="ficha" runat="server" BackColor="#006600" Height="50px" Width="50px" OnClick="Button64_Click" />

        </div>
        </div>
    </form>
</body>
</html>
