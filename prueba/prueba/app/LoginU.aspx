<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginU.aspx.cs" Inherits="prueba.app.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StyleLU.css" type="text/css" media="screen">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <h1>
        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        </h1>
    </header>
        <div id ="entrar">
            <asp:Label ID="Label2" runat="server" Text="Nombre de Usuario: "></asp:Label>
            <asp:TextBox ID="user" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
            
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
            

        </div>
        <div id="aviso">

            <asp:Label ID="noti" runat="server" Text="*El usuario y contraseña son incorrectos" Visible="False"></asp:Label>

        </div>
        <div id="registro">
            <asp:Label ID="Label4" runat="server" Text="*Si no cuenta con una cuenta, registrate aquí    "></asp:Label>
            <asp:Button ID="Button2" runat="server" Height="19px" Text="Registrarse" Width="82px" OnClick="Button2_Click" />
        </div>
        
    </form>
</body>
</html>
