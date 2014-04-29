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

    <script type="text/javascript">
        //IMAGEN 1
        //----------------------------------------------------------------------------
        function validate(sender, args) {
            var filename = document.getElementById("MainContent_AsyncFileUploadLogo1_ctl00").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }


        function getExt(filename) {
            var dotPos = filename.lastIndexOf(".");
            if (dotPos == -1)
                return "";
            return filename.substr(dotPos + 1).toLowerCase();
        }


        function AsignarImagen1() {
            var image = document.getElementById("<%= imgFoto1.ClientID %>");
            var filename = document.getElementById("MainContent_AsyncFileUploadLogo1_ctl00").value;
            image.src = "../UploadedImages/Foto1"  + "." + getExt(filename);
            }
</script>
    
</head>
<body>
<form id="form1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<div class="success": style="position: absolute; width: 900px; height: 866px; z-index: 2; text-align: center; top: 15px; left: 20px;" id="capa1">

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 377px" id="Modelo">
    <asp:TextBox ID="txtModelo" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Modelo</asp:TextBox>
    </div>

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 410px" id="Cilindrada">
    <asp:TextBox ID="txtCilindrada" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Cilindrada</asp:TextBox>
</div>

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 442px" id="Motor">
<asp:TextBox ID="txtMotor" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Motor</asp:TextBox></div>

<div style="position: absolute; width: 423px; height: 255px; z-index: 4; left: 293px; top: 479px" id="Descripcion">
<asp:TextBox ID="txtDescripcion" runat="server" Height="246px" Width="413px" TextMode="MultiLine" BackColor="#585858" ForeColor="White">Descripción</asp:TextBox>
    </div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 3; left: 26px; top: 26px" id="foto1">
    <asp:Image ID="imgFoto1" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px"/>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validate" OnClientUploadComplete="AsignarImagen1" OnUploadedComplete="AsyncFileUpload1_UploadedComplete" ID="AsyncFileUpload1" runat="server" ThrobberID="uploaderGif"/>
<%--     <div style="display: inline-block; float: right" runat="server" id="uploaderGif">
                                <img src="../Images/001.gif" alt="Uploading" id="imgUploader" />
                                Cargando...
                            </div>--%>
    </div>

<div style="position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 26px" id="foto2">
    <asp:ImageButton ID="btnFoto2" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen2.jpg" Width="422px" />
    </div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 298px; margin-left: 0px;" id="foto3">
    <asp:ImageButton ID="btnFoto3" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px" />
    </div>

<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 573px" id="foto4">
    <asp:ImageButton ID="btnFoto4" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px" />
    </div>

<div style="position: absolute; width: 153px; height: 150px; z-index: 1; left: 743px; top: 71px" id="Fondo">
    <asp:ImageButton ID="btnCargarFondo" runat="server" Height="150px" ImageUrl="~/Images/cargarfondo.jpg" Width="153px" />
    </div>

<div style="position: absolute; width: 153px; height: 150px; z-index: 1; left: 743px; top: 600px" id="FondoPrecio">
    <asp:ImageButton ID="btnCargarFondoPrecio" runat="server" ImageUrl="~/Images/cargarfondo.jpg" />
    </div>

<div style="position: absolute; width: 80px; height: 24px; z-index: 4; left: 301px; top: 751px" id="precio">
<asp:TextBox ID="txtPrecio" runat="server" Width="63px" BackColor="#585858" ForeColor="White">0</asp:TextBox>
    </div>

<div style="position: absolute; width: 121px; height: 80px; z-index: 1; left: 292px; top: 298px" id="Logo">
    <asp:ImageButton ID="btnCargarLogo" runat="server" ImageUrl="~/Images/cargarlogo.jpg" />
    </div>


</div>
</form>
</body>
</html>
