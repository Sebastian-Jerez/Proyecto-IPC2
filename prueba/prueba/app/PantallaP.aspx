<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaP.aspx.cs" Inherits="prueba.app.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StylePP.css" type="text/css" media="screen">
    <title>Pantalla Principal</title>
    <style type="text/css">
        .auto-style1 {
            width: 512px;
            height: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
    <header id="cabecera">
        <h2>Othello</h2>
        
    </header>
        
        <div id="principal">
            <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
            <asp:Label ID="nombreUP" runat="server" Text=" "></asp:Label>
            <br />
            <fieldset id="botones">
                <legend>Nueva Partida</legend>
                <asp:Button ID="Button1" runat="server" Height="31px" Text="Partida Individual" Width="197px" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="1 vrs. 1" Height="26px" Width="199px" OnClick="Button2_Click" />
                <br>
                <asp:Button ID="Button3" runat="server" Text="Torneos" Height="26px" Width="197px" />
            </fieldset>
            <img alt="l" id="Image1" class="auto-style1" src="file:///C:/Users/tataj/source/repos/prueba/prueba/app/Images/othelloP.png" /><br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Continuar Partida" Height="25px" Width="196px" OnClick="Button4_Click" />
            
            <asp:Button ID="Button5" runat="server" Height="25px" Text="Iniciar Sesión" Width="198px" OnClick="Button5_Click" />
            
        </div>
    </form>
</body>
</html>
