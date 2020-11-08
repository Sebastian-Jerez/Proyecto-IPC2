<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="prueba.app.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/PerfilU.css" type="text/css" media="screen">
    <title>Perfil de Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="cabecera">
            <h1>Perfil de Usuario</h1>
        </header>
        <br />
        <div id="Dregistro" class="datos">
            <br />
            <asp:Label ID="nom" runat="server" Text="Nombre: " CssClass="prin"></asp:Label>
            <asp:Label ID="nombre" runat="server" Text="nomU"  CssClass="texto"></asp:Label>
            <asp:Label ID="ap" runat="server" Text="Apellido:"  CssClass="prin"></asp:Label>
            <asp:Label ID="apellido" runat="server" Text="apU"  CssClass="texto"></asp:Label>
            <br />
            <br />
            <asp:Label ID="nomU" runat="server" Text="Nombre de Usuario: " CssClass="prin"></asp:Label>
            <asp:Label ID="user" runat="server" Text="nomU" CssClass="texto"></asp:Label>
            <br />
            <br />
            <asp:Label ID="correo" runat="server" Text="Correo:" CssClass="prin"></asp:Label>
            <asp:Label ID="mail" runat="server" Text="correo" CssClass="texto"></asp:Label>
            <asp:Label ID="fnac" runat="server" Text="Fecha de nacimiento:" CssClass="prin"></asp:Label>
            <asp:Label ID="fecha" runat="server" Text="fnac" CssClass="texto"></asp:Label>
            <asp:Label ID="pais" runat="server" Text="Pais: " CssClass="prin"></asp:Label>
            <asp:Label ID="pa" runat="server" Text="pais" CssClass="texto"></asp:Label>
        </div>
        <div id="Dpartidas" class="datos">
            <br />
            <asp:Label ID="pg" runat="server" Text="Partidas Ganadas: " CssClass="prin"></asp:Label>
            <asp:Label ID="partidag" runat="server" Text="partida" CssClass="texto"></asp:Label>
            <asp:Label ID="pe" runat="server" Text="Partidas Empatadas" CssClass="prin"></asp:Label>
            <asp:Label ID="partidasE" runat="server" Text="pejjjj" CssClass="texto"></asp:Label>
            <asp:Label ID="per" runat="server" Text="Partidas Perdidas: " CssClass="prin"></asp:Label>
            <asp:Label ID="per2" runat="server" Text="ppjjj" CssClass="texto"></asp:Label>
            <br />
            <br />
            <asp:Label ID="tj" runat="server" Text="Torneos Jugados:" CssClass="prin"></asp:Label>
            <asp:Label ID="tj2" runat="server" Text="tjjj" CssClass="texto"></asp:Label>
            <asp:Label ID="tg" runat="server" Text="Torneos Ganados: " CssClass="prin"></asp:Label>
            <asp:Label ID="tg2" runat="server" Text="tgjj" CssClass="texto"></asp:Label>
            <asp:Label ID="ptst" runat="server" Text="Puntos en Torneos" CssClass="prin"></asp:Label>
            <asp:Label ID="ptst2" runat="server" Text="ptjjj" CssClass="texto"></asp:Label>
        </div>
        <p>
            <asp:Button ID="pp" runat="server" Text="Regresar Pantalla Principal" OnClick="pp_Click" Width="174px" />
        </p>
    </form>
</body>
</html>
