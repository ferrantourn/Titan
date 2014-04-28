<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TitanWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body { float:left; }
        .success { background-color: #dddddd;}
    </style>

    <style type="text/css">
        #capa1
        {
            height: 800px;
            text-align: center;
            width: 900px;
        }
        #form1
        {
            text-align: center;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div class="success": style="position: absolute; width: 900px; height: 800px; z-index: 2; text-align: center;" id="capa1">

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 377px" id="Modelo">
    <asp:TextBox ID="txtModelo" runat="server" Height="23px" Width="281px">Modelo</asp:TextBox>
    </div>
<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 410px" id="Cilindrada">
    <asp:TextBox ID="txtCilindrada" runat="server" Height="23px" Width="281px">Cilindrada</asp:TextBox>
</div>

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 436px" id="Motor">
<asp:TextBox ID="txtMotor" runat="server" Height="23px" Width="281px">Motor</asp:TextBox></div>

<div style="position: absolute; width: 417px; height: 315px; z-index: 4; left: 293px; top: 468px" id="Descripcion">
<asp:TextBox ID="txtDescripcion" runat="server" Height="224px" Width="398px" TextMode="MultiLine">Descripción</asp:TextBox>
    </div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 3; left: 26px; top: 26px" id="foto1">
<img src="Images/cargarimagen1.jpg" border="0" width="240" height="240"/></div>

<div style="position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 26px" id="foto2">
<img src="Images/cargarimagen2.jpg" border="0" width="420" height="240"/></div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 285px" id="foto3">
<img src="Images/cargarimagen1.jpg" border="0" width="240" height="240"/></div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 545px" id="foto4">
<img src="Images/cargarimagen1.jpg" border="0" width="240" height="240"/></div>

<div style="position: absolute; width: 150px; height: 150px; z-index: 1; left: 743px; top: 71px" id="Div1">
<img src="Images/cargarfondo.jpg" border="0" width="150" height="150"/></div>

<div style="position: absolute; width: 80px; height: 24px; z-index: 4; left: 301px; top: 751px" id="precio">
    <asp:TextBox ID="txtPrecio" runat="server" Width="63px">0</asp:TextBox>
</div>

<div style="position: absolute; width: 185px; height: 76px; z-index: 1; left: 300px; top: 290px" id="Logo">
<img src="Images/cargarlogo.jpg" border="0" width="185" height="76"/></div>


</div>

    </form>
</body>
</html>
