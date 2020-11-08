<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableroOX.aspx.cs" Inherits="prueba.app.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/StyleTX.css" type="text/css" media="screen">
    <title>Othello Xtream</title>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <h1>
        <asp:Label ID="Label1" runat="server" Text="Partida Othelo Xtream"></asp:Label>
        </h1>
    </header>
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
