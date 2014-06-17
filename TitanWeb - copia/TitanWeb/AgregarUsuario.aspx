<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="TitanWeb.AgregarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    .datagrid table { border-collapse: collapse; text-align: left; width: 100%; } .datagrid {font: normal 12px/150% Arial, Helvetica, sans-serif; background: #DDDDDD; overflow: hidden; border: 4px solid #585858; -webkit-border-radius: 20px; -moz-border-radius: 20px; border-radius: 20px; }.datagrid table td, .datagrid table th { padding: 8px 20px; }.datagrid table tbody td { color: #00496B; border-left: 1px solid #E1EEF4;font-size: 12px;font-weight: normal; }.datagrid table tbody td:first-child { border-left: none; }.datagrid table tbody tr:last-child td { border-bottom: none; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="datagrid" style="width: 600px; height: 315px; z-index: 1; text-align: left;" id="GuardarUsuario">

    
        <br />
        <asp:Label ID="Label1" runat="server" style="text-align: center" Text="AGREGAR USUARIO"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="NOMBRE DE USUARIO:"></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="PASSWORD:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="REPETIR PASSWORD:"></asp:Label>
        <asp:TextBox ID="txtPassword2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="AGREGAR" />
        <br />

    
        <br />
        <asp:Label ID="txtError" runat="server" Text="___"></asp:Label>

    
    </div>
    </form>
</body>
</html>
