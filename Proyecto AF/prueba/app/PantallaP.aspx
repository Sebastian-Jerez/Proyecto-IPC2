<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaP.aspx.cs" Inherits="prueba.app.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/EstiloPP.css" type="text/css" media="screen">
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
            <asp:Label ID="Label1" runat="server" Text="Usuario: " CssClass="valorU"></asp:Label>
            <asp:Label ID="nomU" runat="server" Text=" Ingresar usuario" CssClass="valorU"></asp:Label>
            <br />
            <div id="juegos">
            <fieldset id="botones">
                <legend>Nueva Partida</legend>
                <asp:Button ID="Button1" runat="server" Height="31px" Text="Partida Individual" Width="197px" OnClick="Button1_Click" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="1 vrs. 1" Height="26px" Width="199px" OnClick="Button2_Click" />
                <br>
                <asp:Button ID="Button3" runat="server" Text="Torneos" Height="26px" Width="197px" />
            </fieldset> 
            
             </div>
            <div id="logo">
                <asp:Image ID="Image1" runat="server" Height="290px" ImageUrl="~/app/Images/othelloP - copia.png" Width="530px" ImageAlign="Left" />
            </div>
            <br />
            <br />
            <div id="extra">
            <asp:Button ID="Button4" runat="server" Text="Continuar Partida" Height="25px" Width="196px" OnClick="Button4_Click" />
            
                <asp:TextBox ID="nomA" runat="server"></asp:TextBox>
            
                <asp:Button ID="aceptar" runat="server" Text="Aceptar" OnClick="aceptar_Click" />
            
            <asp:Button ID="Button5" runat="server" Height="25px" Text="Iniciar Sesión" Width="198px" OnClick="Button5_Click" />
            </div>
            
        </div>
        
    </form>
</body>
</html>
