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
        <div id="extra" class="jugadores">
            <asp:Label ID="Ex" runat="server" Text="Personalización Extra:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="MI" runat="server" Text="Othello Reversi:"></asp:Label>
            <asp:CheckBox ID="Minverso" runat="server" Text="Modo Inverso" OnCheckedChanged="Minverso_CheckedChanged"/>
            <br />
            <br />
            <asp:CheckBox ID="AP" runat="server" Text="Apertura Personalizada" AutoPostBack="True" OnCheckedChanged="AP_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="ColJ1" runat="server" Text="Colores Jugador #1" CssClass="textI"></asp:Label>
            <asp:CheckBox ID="C1" runat="server" Text="Rojo" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C1_CheckedChanged"/>
            <asp:CheckBox ID="C2" runat="server" Text="Azul" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C2_CheckedChanged"/>
            <asp:CheckBox ID="C3" runat="server" Text="Negro" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C3_CheckedChanged"/>
            <asp:CheckBox ID="C4" runat="server" Text="Blanco" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C4_CheckedChanged"/>
            <asp:CheckBox ID="C5" runat="server" Text="Morado" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C5_CheckedChanged"/>
            <asp:CheckBox ID="C6" runat="server" Text="Amarillo" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C6_CheckedChanged"/>
            <br />
            <br />
            <asp:Label ID="ColJ2" runat="server" Text="Colores Jugador #2" CssClass="textI"></asp:Label>
            <asp:CheckBox ID="C11" runat="server" Text="Rojo" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C11_CheckedChanged"/>
            <asp:CheckBox ID="C22" runat="server" Text="Azul" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C22_CheckedChanged"/>
            <asp:CheckBox ID="C33" runat="server" Text="Negro" CssClass="colJ" AutoPostBack="True" OnCheckedChanged="C33_CheckedChanged"/>
            <asp:CheckBox ID="C44" runat="server" Text="Blanco" CssClass="colJ" AutoPostBack="True"/>
            <asp:CheckBox ID="C55" runat="server" Text="Morado" CssClass="colJ" AutoPostBack="True"/>
            <asp:CheckBox ID="C66" runat="server" Text="Amarillo" CssClass="colJ" AutoPostBack="True"/>
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
