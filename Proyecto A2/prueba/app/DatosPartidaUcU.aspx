<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosPartidaUcU.aspx.cs" Inherits="prueba.app.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StylePUcU.css" type="text/css" media="screen">
    <title>Datos de la Partida</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="cabecera">
            <h2>Datos de la Partida</h2>
        </header>
        <div id="jugador1" class="jugadores">
            <asp:Label ID="Label1" runat="server" Text="Nombre Jugador #1:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="nombreJ1" runat="server" Text="Nombre" CssClass="Sdatos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Color de la ficha:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="negro1" runat="server" Text="Negro" AutoPostBack="True" OnCheckedChanged="negro1_CheckedChanged" CssClass="optC"/>
            <asp:CheckBox ID="blanco1" runat="server" Text="Blanco" AutoPostBack="True" OnCheckedChanged="blanco1_CheckedChanged" CssClass="optC"/>
            <asp:CheckBox ID="aleatorio1" runat="server" Text="Aleatorio" AutoPostBack="True" OnCheckedChanged="aleatorio1_CheckedChanged" CssClass="optC"/>
        </div>
        <br />
        <div id="jugador2" class="jugadores">
            <asp:Label ID="Label2" runat="server" Text="Nombre Jugador #2:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="nombreJ2" runat="server" Text="Seleccionar Usuario" CssClass="Sdatos" Width="250px"></asp:Label>
            <asp:CheckBox ID="userR" runat="server" Text="Usuario Registrado" CssClass="optC" AutoPostBack="True" OnCheckedChanged="userR_CheckedChanged"/>
            <asp:CheckBox ID="userNR" runat="server" Text="Usuario externo" CssClass="optC" AutoPostBack="True" OnCheckedChanged="userNR_CheckedChanged"/>
            <br />
            <br />
            <asp:DropDownList ID="listaUsuarios" runat="server" Height="39px" Width="129px" AutoPostBack="True" OnSelectedIndexChanged="listaUsuarios_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:TextBox ID="nombreNR" runat="server" Text="Ingresa el nombre del Jugador #2" Width="174px" AutoPostBack="True" OnTextChanged="nombreNR_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Color de la ficha:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="negro2" runat="server" Text="Negro" AutoPostBack="True" OnCheckedChanged="negro2_CheckedChanged" CssClass="optC"/>
            <asp:CheckBox ID="blanco2" runat="server" Text="Blanco" AutoPostBack="True" OnCheckedChanged="blanco2_CheckedChanged" CssClass="optC"/>
            <asp:CheckBox ID="aleatorio2" runat="server" Text="Aleatorio" AutoPostBack="True" OnCheckedChanged="aleatorio2_CheckedChanged" CssClass="optC"/>

        </div>
        <br />
        <div id="botonC">
            <p>
                <asp:Button ID="comenzar" runat="server" OnClick="Button1_Click" Text="Comenzar" />
            </p>
        </div>
        
    </form>
</body>
</html>
