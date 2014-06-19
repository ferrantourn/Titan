<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TitanWeb.Login" %>

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
    <div class="datagrid" style="width: 600px; height: 315px; z-index: 1; text-align: right;" id="LoginUsuario">

    <table border="0" width="100%" cellspacing="4" cellpadding="3">
	<tr>
		<td colspan="2"><p align="center">
        <asp:Label ID="Label1" runat="server" style="text-align: center" Text="LOGIN"></asp:Label>
        </td>
	</tr>
	<tr>
		<td align="right">
        <asp:Label ID="Label2" runat="server" Text="NOMBRE DE USUARIO:"></asp:Label>
        </td>
		<td align="left">
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
        </td>
	</tr>
	<tr>
		<td align="right">
        <asp:Label ID="Label3" runat="server" Text="PASSWORD:"></asp:Label>
        </td>
		<td align="left">
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
	</tr>
	<tr>
		<td align="right">&nbsp;</td>
		<td align="left">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" align="right">
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="LOGIN" />
        </td>
	</tr>
</table>


        <asp:Label ID="txtError" runat="server" Text="___"></asp:Label>

    
        <br />
        <div class="datagrid" style="position: absolute; width: 114px; z-index: 1; text-align: center; top: 272px; left: 482px;" id="AgregarUsuario">
        <asp:LinkButton ID="lnkAgregarUsuario" runat="server" PostBackUrl="AgregarUsuario.aspx" style="text-align: center">Agregar Usuario</asp:LinkButton>
        </div>
        <br />
        <br />

    
    </div>
    </form>
</body>
</html>
