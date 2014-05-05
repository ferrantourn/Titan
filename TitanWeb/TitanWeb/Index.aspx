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
            width: 1100px;
            text-align: center;
        }
        #form1
        {
            text-align: center;
        }
    </style>
    
    
    <script type="text/javascript" >



        //VALIDAR IMAGEN 1
        //----------------------------------------------------------------------------
        function validate(sender, args) {

            var filename = document.getElementById("AsyncFileUpload1_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }
        //VALIDAR IMAGEN 2
        //---------------------------------------------------------------------------
        function validate2(sender, args) {

            var filename = document.getElementById("AsyncFileUpload2_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }
        //VALIDAR IMAGEN 3
        //---------------------------------------------------------------------------
        function validate3(sender, args) {

            var filename = document.getElementById("AsyncFileUpload3_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }
        //VALIDAR IMAGEN 4
        //---------------------------------------------------------------------------
        function validate4(sender, args) {

            var filename = document.getElementById("AsyncFileUpload4_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }
        //VALIDAR FONDO
        //---------------------------------------------------------------------------
        function validateFondo(sender, args) {

            var filename = document.getElementById("AsyncFileUploadFondo_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }

        //VALIDAR FONDO PRECIO
        //---------------------------------------------------------------------------
        function validateFondoPrecio(sender, args) {

            var filename = document.getElementById("AsyncFileUploadFondoPrecio_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }

        //VALIDAR FONDO LOGO
        //---------------------------------------------------------------------------
        function validateLogo(sender, args) {

            var filename = document.getElementById("AsyncFileUploadLogo_ctl02").value;
            var ext = getExt(filename);
            if (ext == "jpg" || ext == "jpeg" || ext == "png")
                return true;
            alert("Solo se aceptan imágenes : (.jpg .jpeg .png).");
            return args.set_cancel(true);
        }
        //GET EXTENSION
        //---------------------------------------------------------------------------
        function getExt(filename) {
            var dotPos = filename.lastIndexOf(".");
            if (dotPos == -1)
                return "";
            return filename.substr(dotPos + 1).toLowerCase();
        }

        //ASIGNAR IMAGEN 1
        //---------------------------------------------------------------------------
        function AsignarImagen1() {

            var image = document.getElementById("<%= imgFoto1.ClientID %>");
            var filename = document.getElementById("AsyncFileUpload1_ctl02").value;
            image.src = "../UploadedImages/Foto1"  + "." + getExt(filename);
        }
        //ASIGNAR IMAGEN 2
        //---------------------------------------------------------------------------
        function AsignarImagen2() {

            var image = document.getElementById("<%= imgFoto2.ClientID %>");
            var filename = document.getElementById("AsyncFileUpload2_ctl02").value;
            image.src = "../UploadedImages/Foto2" + "." + getExt(filename);
        }
        //ASIGNAR IMAGEN 3
        //---------------------------------------------------------------------------
        function AsignarImagen3() {

            var image = document.getElementById("<%= imgFoto3.ClientID %>");
                    var filename = document.getElementById("AsyncFileUpload3_ctl02").value;
                    image.src = "../UploadedImages/Foto3" + "." + getExt(filename);
        }
        //ASIGNAR IMAGEN 4
        //---------------------------------------------------------------------------
        function AsignarImagen4() {

            var image = document.getElementById("<%= imgFoto4.ClientID %>");
                    var filename = document.getElementById("AsyncFileUpload4_ctl02").value;
                    image.src = "../UploadedImages/Foto4" + "." + getExt(filename);
        }
        //ASIGNAR IMAGEN FONDO
        //---------------------------------------------------------------------------
        function AsignarImagenFondo() {

            //var image = document.getElementById("%= imgFotoFondo.ClientID %>");
            //var filename = document.getElementById("AsyncFileUploadFondo_ctl02").value;
            //image.src = "../UploadedImages/Fondo" + "." + getExt(filename);
        }
        //ASIGNAR IMAGEN FONDO PRECIO
        //---------------------------------------------------------------------------
        function AsignarImagenFondoPrecio() {

            //var image = document.getElementById("%= imgFotoFondoPrecio.ClientID %>");
            //var filename = document.getElementById("AsyncFileUploadFondoPrecio_ctl02").value;
            //image.src = "../UploadedImages/FondoPrecio" + "." + getExt(filename);
        }
        //ASIGNAR IMAGEN LOGO
        //---------------------------------------------------------------------------
        function AsignarImagenLogo() {

           // var image = document.getElementById("%= imgFotoLogo.ClientID %>");
           // var filename = document.getElementById("AsyncFileUploadLogo_ctl02").value;
           // image.src = "../UploadedImages/FotoLogo" + "." + getExt(filename);
        }



        function uploadError() {
            alert("error!");
         }
</script>
    
</head>
<body>
<form id="form1" runat="server">
<ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" EnablePageMethods="true" CombineScripts="true" EnableScriptGlobalization="true" runat="server"></ajaxToolkit:ToolkitScriptManager>
<div class="success": width: 1100px; height: 866px; z-index: 2; top: 15px; left: 20px;" id="capa1">

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 411px" id="Modelo">
    <asp:TextBox ID="txtModelo" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Modelo</asp:TextBox>
    </div>

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 445px" id="Cilindrada">
    <asp:TextBox ID="txtCilindrada" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Cilindrada</asp:TextBox>
</div>

<div style="position: absolute; width: 281px; height: 23px; z-index: 4; left: 429px; top: 480px" id="Motor">
<asp:TextBox ID="txtMotor" runat="server" Height="23px" Width="281px" BackColor="#585858" ForeColor="White">Motor</asp:TextBox></div>

<div style="position: absolute; width: 423px; height: 255px; z-index: 4; left: 293px; top: 524px" id="Descripcion">
<asp:TextBox ID="txtDescripcion" runat="server" Height="246px" Width="413px" TextMode="MultiLine" BackColor="#585858" ForeColor="White" Wrap="False" style = "resize:none">Descripción</asp:TextBox>
    </div>

       <%-----------------------------------Foto3 ------------------------------------%>

<div style="position: absolute; width: 240px; height: 240px; z-index: 3; left: 26px; top: 26px" id="foto1">
    <asp:Image ID="imgFoto1" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px" />
    <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: 57px; top: 204px" runat="server" id="uploaderGif">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploader" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validate" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagen1" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUpload1_UploadedComplete" ID="AsyncFileUpload1" runat="server" ThrobberID="uploaderGif" Width="240" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD" />
</div>
    <%-----------------------------------Foto2 ------------------------------------%>
<div style="position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 26px" id="foto2">
    <asp:Image  ID="imgFoto2" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen2.jpg" Width="422px" />
        <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: 147px; top: 204px" runat="server" id="uploaderGif2">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploader2" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validate2" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagen2" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUpload2_UploadedComplete" ID="AsyncFileUpload2" runat="server" ThrobberID="uploaderGif2" Width="420" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD"/>
    </div>
    <%-----------------------------------Foto3 ------------------------------------%>
<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 298px; margin-left: 0px;" id="foto3">
    <asp:Image ID="imgFoto3" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px" />
    <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: 57px; top: 204px" runat="server" id="uploaderGif3">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploader3" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validate3" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagen3" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUpload3_UploadedComplete" ID="AsyncFileUpload3" runat="server" ThrobberID="uploaderGif3" Width="240" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD"/>
</div>
    <%-----------------------------------Foto4 ------------------------------------%>
<div style="position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 573px" id="foto4">
    <asp:Image ID="imgFoto4" runat="server" Height="240px" ImageUrl="~/Images/cargarimagen1.jpg" Width="240px" />
    <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: 57px; top: 204px" runat="server" id="uploaderGif4">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploader4" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validate4" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagen4" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUpload4_UploadedComplete" ID="AsyncFileUpload4" runat="server" ThrobberID="uploaderGif4" Width="240" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD"/>
</div>

        <%-----------------------------------Fondo ------------------------------------%>
<div style="position: absolute; width: 153px; height: 150px; z-index: 1; left: 743px; top: 71px" id="Fondo">
    <asp:Image ID="imgFotoFondo" runat="server" Height="150px" ImageUrl="~/Images/cargarfondo.jpg" Width="153px" />
    <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: 20px; top: 129px" runat="server" id="uploaderGifFondo">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploaderFondo" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validateFondo" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagenFondo" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUploadFondo_UploadedComplete" ID="AsyncFileUploadFondo" runat="server" ThrobberID="uploaderGifFondo" Width="240" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD" />
</div>

    <%-----------------------------------Fondo precio-----------------------------------%>
<div style="position: absolute; width: 153px; height: 150px; z-index: 1; left: 743px; top: 600px" id="FondoPrecio">
    <asp:Image ID="imgFotoFondoPrecio" runat="server" ImageUrl="~/Images/cargarfondo.jpg" />
    <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: 20px; top: 129px" runat="server" id="uploaderGifFondoPrecio">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploaderFondoPrecio" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validateFondoPrecio" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagenFondoPrecio" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUploadFondoPrecio_UploadedComplete" ID="AsyncFileUploadFondoPrecio" runat="server" ThrobberID="uploaderGifFondoPrecio" Width="240" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD" />
    </div>

    <%-----------------------------------Logo-----------------------------------%>
<div style="position: absolute; width: 121px; height: 80px; z-index: 1; left: 292px; top: 298px" id="Logo">
    <asp:Image ID="imgFotoLogo" runat="server" ImageUrl="~/Images/cargarlogo.jpg" />
    <div style="position: absolute; width: 126px; height: 22px; z-index: 4; left: -3px; top: 53px" runat="server" id="uploaderGifLogo">
        <img src="../Images/018.gif" alt="Subiendo" id="imgUploaderLogo" />
    </div>
    <ajaxToolkit:AsyncFileUpload OnClientUploadStarted="validateLogo" UploaderStyle="Traditional" OnClientUploadComplete="AsignarImagenLogo" OnClientUploadError="uploadError" OnUploadedComplete="AsyncFileUploadLogo_UploadedComplete" ID="AsyncFileUploadLogo" runat="server" ThrobberID="uploaderGifLogo" Width="240" BackColor="#DDDDDD" CompleteBackColor="#DDDDDD" ForeColor="#585858" UploadingBackColor="#DDDDDD" />
</div>

     <%-----------------------------------Otros-----------------------------------%>
<div style="position: absolute; width: 160px; height: 119px; z-index: 1; left: 743px; top: 800px" id="Div1">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="GuardarJPG" runat="server" OnClick="GuardarJPG_Click" Text="Guardar JPG" />
            <br />
            <asp:HyperLink ID="VinculoJPG" runat="server" NavigateUrl="~/index.jpg">___</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnGuardarProyecto" runat="server" Text="Guardar Proyecto" Width="121px" OnClick="btnGuardarProyecto_Click" />
            <br />
            
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Button ID="btnAbrirProyecto" runat="server" Text="Abrir Proyecto" OnClick="btnAbrirProyecto_Click" />
    </div>
<div style="position: absolute; width: 138px; height: 24px; z-index: 4; left: 367px; top: 790px" id="precio">
<asp:Label ID="Label1" runat="server" Text="Precio:"></asp:Label>
<asp:TextBox ID="txtPrecio" runat="server" Width="63px" BackColor="#585858" ForeColor="White">0</asp:TextBox>
    </div>



</div>
</form>
</body>
</html>
