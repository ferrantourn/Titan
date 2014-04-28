<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TitanWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!--magia negra para hacer que el fondo sea gris en un div:-->
    <style>
        body { float:left; } 
        .success { background-color: #dddddd;}
    </style>

    <style type="text/css"> 
        #capa1
        {
            height: 900px;
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
    <asp:TextBox ID="txtModelo" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Modelo</asp:TextBox>
    </div>
<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 410px" id="Cilindrada">
    <asp:TextBox ID="txtCilindrada" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Cilindrada</asp:TextBox>
</div>

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 442px" id="Motor">
<asp:TextBox ID="txtMotor" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Motor</asp:TextBox></div>

<div style="position: absolute; width: 423px; height: 304px; z-index: 4; left: 293px; top: 479px" id="Descripcion">
<asp:TextBox ID="txtDescripcion" runat="server" Height="246px" Width="413px" TextMode="MultiLine" BackColor="#585858" ForeColor="White">Descripción</asp:TextBox>
    </div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 3; left: 26px; top: 26px" id="foto1">
    <asp:ImageButton ID="btnFoto1" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px" />
    </div>

<div style="position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 26px" id="foto2">
    <asp:ImageButton ID="btnFoto2" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen2.jpg" Width="422px" />
    </div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 285px" id="foto3">
<img src="Images/cargarimagen1.jpg" border="0" width="240" height="240"/></div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 545px" id="foto4">
<img src="Images/cargarimagen1.jpg" border="0" width="240" height="240"/></div>

<div style="position: absolute; width: 153px; height: 150px; z-index: 1; left: 743px; top: 71px" id="Fondo">
    <asp:ImageButton ID="btnCargarFondo" runat="server" Height="150px" ImageUrl="~/Images/cargarfondo.jpg" Width="153px" />
    </div>

<div style="position: absolute; width: 153px; height: 150px; z-index: 1; left: 743px; top: 600px" id="FondoPrecio">
    <asp:ImageButton ID="btnCargarFondoPrecio" runat="server" ImageUrl="~/Images/cargarfondo.jpg" />
    </div>

<div style="position: absolute; width: 80px; height: 24px; z-index: 4; left: 301px; top: 751px" id="precio">
<asp:TextBox ID="txtPrecio" runat="server" Width="63px" BackColor="#585858" ForeColor="White">0</asp:TextBox></div>

<div style="position: absolute; width: 185px; height: 76px; z-index: 1; left: 300px; top: 290px" id="Logo">
<img src="Images/cargarlogo.jpg" border="0" width="185" height="76"/></div>


</div>

    </form>
</body>
</html>
