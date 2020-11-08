<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroU.aspx.cs" Inherits="prueba.app.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Usuarios</title>
    <link rel="stylesheet" href="Styles/StyleRU.css" type="text/css" media="screen">
</head>
<body>
    <form id="form1" runat="server">
        <div id="datos">
            <h1>
            <asp:Label ID="Label1" runat="server" Text="Label">Registro de Usuarios</asp:Label>
            </h1>
            <br />
            <br />
            <fieldset class="sec1">
                
            <legend id="datos2">Datos personales:</legend>
                
            <label for="nombreU" id="nombre">Nombre:</label>
            <label for="apellidoU" id="apellido1">Apellido:</label>
            
            <br>
                
            &nbsp;<asp:TextBox ID="nombreU" runat="server"></asp:TextBox>
            &nbsp;<asp:TextBox ID="apellidoU" runat="server"></asp:TextBox>
                
            </fieldset>
            <br />
            <br />
            <fieldset class="sec1">
            
            <legend id="datos2">Datos de la cuenta:</legend>
                
            <label for="user" id="user">Usuario:</label> <br>
            &nbsp;<asp:TextBox ID="user" runat="server"></asp:TextBox>
            
            <br>
            <br>
                
            <label for="passU" id="pass">Contraseña:</label>
            <label for="pass22U" id="pass2">Confirmar contraseña:</label>
                
            <br>
            &nbsp;<asp:TextBox ID="passU" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;<asp:TextBox ID="pass22U" runat="server" TextMode="Password"></asp:TextBox>
             
            </fieldset>

            <br />
            <br />
            
            <fieldset class="sec1">
            
            <legend id="datos2">Datos adicionales:</legend>
                
            <label for="fnac" id="fnac">Fecha de Nacimiento:</label>
            <label for="pais" id="pais1">País:</label><br>
                
            &nbsp;<asp:TextBox ID="fnac" runat="server" TextMode="DateTime"></asp:TextBox>
                <asp:DropDownList ID="pais" runat="server" Height="32px" OnSelectedIndexChanged="pais_SelectedIndexChanged" Width="300px">
                </asp:DropDownList>
                <br>
                
            <br>
            <br>
            
            <label for="correo" id="correo">Correo:</label> <br>
            &nbsp;<asp:TextBox ID="correo" runat="server"></asp:TextBox>
                
            
            <br>
            <br>
                
            </fieldset>

            <br />
                <br />
                <asp:Button ID="Button1" runat="server" Height="36px" Text="Registar Usuario" Width="149px" OnClick="Button1_Click" />
            
            <br>

        </div>
    </form>
</body>
</html>
