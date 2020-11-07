<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosXT.aspx.cs" Inherits="prueba.app.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StyleDOX.css" type="text/css" media="screen">
    <title>Othello Xtream</title>
</head>
<body>
    <form id="form1" runat="server">
         <header id="cabecera">
            <h2>Datos de la Partida / Othello Xtream</h2>
        </header>
        <div id="jugador1" class="jugadores">
            <asp:Label ID="NomJ1" runat="server" Text="Nombre Jugador #1:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="nombreJ1" runat="server" Text="Nombre" CssClass="Sdatos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Color de la ficha:" CssClass="datos"></asp:Label>
            <asp:Label ID="error1" runat="server" Text="*Debe eleigr al menos un color y no elegir mas de 5 colores" CssClass="error"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="negro1" runat="server" Text="Negro" AutoPostBack="True" CssClass="optC" OnCheckedChanged="negro1_CheckedChanged"/>
            <asp:CheckBox ID="blanco1" runat="server" Text="Blanco" AutoPostBack="True" CssClass="optC" OnCheckedChanged="blanco1_CheckedChanged"/>
            <asp:CheckBox ID="celeste1" runat="server" Text="Celeste" AutoPostBack="True" CssClass="optC" OnCheckedChanged="aleatorio1_CheckedChanged"/>
            <asp:CheckBox ID="gris1" runat="server" Text="Gris" AutoPostBack="True" CssClass="optC" OnCheckedChanged="gris1_CheckedChanged"/>
            <asp:CheckBox ID="violeta1" runat="server" Text="Violeta" AutoPostBack="True" CssClass="optC" OnCheckedChanged="violeta1_CheckedChanged"/>
            <asp:CheckBox ID="verde1" runat="server" Text="Verde" AutoPostBack="True" CssClass="optC" OnCheckedChanged="verde1_CheckedChanged"/>
            <asp:CheckBox ID="naranja1" runat="server" Text="Naranja" AutoPostBack="True" CssClass="optC" OnCheckedChanged="naranja1_CheckedChanged"/>
            <asp:CheckBox ID="azul1" runat="server" Text="Azul" AutoPostBack="True" CssClass="optC" OnCheckedChanged="azul1_CheckedChanged"/>
            <asp:CheckBox ID="amarillo1" runat="server" Text="Amarillo" AutoPostBack="True" CssClass="optC" OnCheckedChanged="amarillo1_CheckedChanged"/>
            <asp:CheckBox ID="rojo1" runat="server" Text="Rojo" AutoPostBack="True" CssClass="optC" OnCheckedChanged="rojo1_CheckedChanged"/>

        </div>
        <br />
        <div id="jugador2" class="jugadores">
            <asp:Label ID="Label2" runat="server" Text="Nombre Jugador #2:" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="nombreJ2" runat="server" Text="Seleccionar Usuario" CssClass="Sdatos" Width="250px"></asp:Label>
            <asp:CheckBox ID="userR" runat="server" Text="Usuario Registrado" CssClass="optC" AutoPostBack="True" OnCheckedChanged="userR_CheckedChanged" />
            <asp:CheckBox ID="userNR" runat="server" Text="Usuario externo" CssClass="optC" AutoPostBack="True" OnCheckedChanged="userNR_CheckedChanged" />
            <br />
            <br />
            <asp:DropDownList ID="listaUsuarios" runat="server" Height="39px" Width="129px" AutoPostBack="True" OnSelectedIndexChanged="listaUsuarios_SelectedIndexChanged" >
            </asp:DropDownList>

            <asp:TextBox ID="nombreNR" runat="server" Text="Ingresa el nombre del Jugador #2" Width="174px" AutoPostBack="True" OnTextChanged="nombreNR_TextChanged" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Color de la ficha:" CssClass="datos"></asp:Label>
            <asp:Label ID="error2" runat="server" Text="*Debe eleigr al menos un color y no elegir mas de 5 colores" CssClass="error"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="negro2" runat="server" Text="Negro" AutoPostBack="True" CssClass="optC" OnCheckedChanged="negro2_CheckedChanged"/>
            <asp:CheckBox ID="blanco2" runat="server" Text="Blanco" AutoPostBack="True" CssClass="optC" OnCheckedChanged="blanco2_CheckedChanged"/>
            <asp:CheckBox ID="celeste2" runat="server" Text="Celeste" AutoPostBack="True" CssClass="optC" OnCheckedChanged="celeste2_CheckedChanged"/>
            <asp:CheckBox ID="gris2" runat="server" Text="Gris" AutoPostBack="True" CssClass="optC" OnCheckedChanged="gris2_CheckedChanged"/>
            <asp:CheckBox ID="violeta2" runat="server" Text="Violeta" AutoPostBack="True" CssClass="optC" OnCheckedChanged="violeta2_CheckedChanged"/>
            <asp:CheckBox ID="verde2" runat="server" Text="Verde" AutoPostBack="True" CssClass="optC" OnCheckedChanged="verde2_CheckedChanged"/>
            <asp:CheckBox ID="neranja2" runat="server" Text="Naranja" AutoPostBack="True" CssClass="optC" OnCheckedChanged="neranja2_CheckedChanged"/>
            <asp:CheckBox ID="azul2" runat="server" Text="Azul" AutoPostBack="True" CssClass="optC" OnCheckedChanged="azul2_CheckedChanged"/>
            <asp:CheckBox ID="amarillo2" runat="server" Text="Amarillo" AutoPostBack="True" CssClass="optC" OnCheckedChanged="amarillo2_CheckedChanged"/>
            <asp:CheckBox ID="rojo2" runat="server" Text="Rojo" AutoPostBack="True" CssClass="optC" OnCheckedChanged="rojo2_CheckedChanged"/>

        </div>
        <br />
        <div id="DTablero" class="jugadores">
            <asp:Label ID="Label5" runat="server" Text="Tablero" CssClass="datos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Tamaño del tablero MxN (Tamaño minimo 6 y máximo 20, par)"  CssClass="Sdatos"></asp:Label>
            <br />
            <asp:Label ID="error3" runat="server" Text="*No puede ser numero impar y debe estar en el rango de 6 a 20" CssClass="error"></asp:Label>
            <br />
            <asp:TextBox ID="M" runat="server" Height="27px" Width="31px"></asp:TextBox>
            <asp:Label ID="X" runat="server" Text=" X "></asp:Label>
            <asp:TextBox ID="N" runat="server" Height="27px" Width="31px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="CP" runat="server" Text="Cargar Partida"  CssClass="Sdatos"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BCP" runat="server" Text="Cargar Archivo" />
            <asp:TextBox ID="TBCP" runat="server" CssClass ="carga"></asp:TextBox>
            <asp:Button ID="BCA" runat="server" Text="Abrir" CssClass ="carga" />
        </div>
        <br />
        <div id="botonC">
            <p>
                <asp:Button ID="comenzar" runat="server" Text="Comenzar" OnClick="comenzar_Click" />
            </p>
        </div>
    </form>
</body>
</html>
