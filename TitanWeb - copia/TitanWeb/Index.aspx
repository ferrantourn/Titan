<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TitanWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta http-equiv="Cache-Control" content="no-cache"/>
<meta http-equiv="Pragma" content="no-cache"/>
<meta http-equiv="Expires" content="0"/>
<meta http-equiv="Pragma-directive: no-cache"/>
<meta http-equiv="Cache-directive: no-cache"/>
    <title></title>
    <!--magia negra para hacer que el fondo sea gris en un div:-->
    <style>
        body { float:left; } 
        .success { background-color: #dddddd;}
    </style>
    <%--fin magia negra--%>

    <style type="text/css">
    .datagrid table { border-collapse: collapse; text-align: left; width: 100%; } .datagrid {font: normal 12px/150% Arial, Helvetica, sans-serif; background: #DDDDDD; overflow: hidden; border: 4px solid #585858; -webkit-border-radius: 20px; -moz-border-radius: 20px; border-radius: 20px; }.datagrid table td, .datagrid table th { padding: 8px 20px; }.datagrid table tbody td { color: #00496B; border-left: 1px solid #E1EEF4;font-size: 12px;font-weight: normal; }.datagrid table tbody td:first-child { border-left: none; }.datagrid table tbody tr:last-child td { border-bottom: none; }
    </style>

    <style type="text/css">
            .mGrid {   
        width: 100%;   
        background-color: #fff;   
        margin: 5px 0 10px 0;   
        border: solid 1px #525252;   
        border-collapse:collapse;   
    }  
    .mGrid td {   
        padding: 2px;   
        border: solid 1px #c1c1c1;   
        color: #717171;   
    }  
    .mGrid th {   
        padding: 4px 2px;   
        color: #fff;   
        background: #424242 url(grd_head.png) repeat-x top;   
        border-left: solid 1px #525252;   
        font-size: 0.9em;   
    }  
    .mGrid .alt { background: #fcfcfc url(grd_alt.png) repeat-x top; }  
    .mGrid .pgr { background: #424242 url(grd_pgr.png) repeat-x top; }  
    .mGrid .pgr table { margin: 5px 0; }  
    .mGrid .pgr td {   
        border-width: 0;   
        padding: 0 6px;   
        border-left: solid 1px #666;   
        font-weight: bold;   
        color: #fff;   
        line-height: 12px;   
     }     
    .mGrid .pgr a { color: #666; text-decoration: none; }  
    .mGrid .pgr a:hover { color: #000; text-decoration: none; }

    .btn {
   border-top: 1px solid #dddddd;
   background: #dddddd;
   background: -webkit-gradient(linear, left top, left bottom, from(#383838), to(#dddddd));
   background: -webkit-linear-gradient(top, #383838, #dddddd);
   background: -moz-linear-gradient(top, #383838, #dddddd);
   background: -ms-linear-gradient(top, #383838, #dddddd);
   background: -o-linear-gradient(top, #383838, #dddddd);
   padding: 10.5px 21px;
   -webkit-border-radius: 19px;
   -moz-border-radius: 19px;
   border-radius: 19px;
   -webkit-box-shadow: rgba(0,0,0,1) 0 1px 0;
   -moz-box-shadow: rgba(0,0,0,1) 0 1px 0;
   box-shadow: rgba(0,0,0,1) 0 1px 0;
   text-shadow: rgba(0,0,0,.4) 0 1px 0;
   color: white;
   font-size: 16px;
   font-family: Georgia, serif;
   text-decoration: none;
   vertical-align: middle;
   }
.btn:hover {
   border-top-color: #383838;
   background: #383838;
   color: #ffffff;
   }
.btn:active {
   border-top-color: #dddddd;
   background: #dddddd;
   }

.btn2 {
   border-top: 1px solid #ffffff;
   background: #65a9d7;
   background: -webkit-gradient(linear, left top, left bottom, from(#383838), to(#dddddd));
   background: -webkit-linear-gradient(top, #383838, #dddddd);
   background: -moz-linear-gradient(top, #383838, #dddddd);
   background: -ms-linear-gradient(top, #383838, #dddddd);
   background: -o-linear-gradient(top, #383838, #dddddd);
   padding: 11px 22px;
   -webkit-border-radius: 6px;
   -moz-border-radius: 6px;
   border-radius: 6px;
   -webkit-box-shadow: rgba(0,0,0,1) 0 1px 0;
   -moz-box-shadow: rgba(0,0,0,1) 0 1px 0;
   box-shadow: rgba(0,0,0,1) 0 1px 0;
   text-shadow: rgba(0,0,0,.4) 0 1px 0;
   color: white;
   font-size: 16px;
   font-family: Georgia, serif;
   text-decoration: none;
   vertical-align: middle;
   }
.btn2:hover {
   border-top-color: #383838;
   background: #383838;
   color: #ffffff;
   }
.btn2:active {
   border-top-color: #dddddd;
   background: #dddddd;
   }
    </style>

    <style type="text/css"> 
        #capa1
        {
            height: 900px;
            width: 1200px;
            text-align: center;
        }
        #form1
        {
            text-align: center;
        }
        #btnAbrir
        {
            width: 142px;
        }
        .auto-style2
        {
            text-align: left;
        }
        </style>
    
    <link href="css/jquery.Jcrop.min.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.Jcrop.min.js"></script>

<%--    	<link href="http://edge1y.tapmodo.com/deepliq/global.css" rel="stylesheet" type="text/css" />
  <link rel="stylesheet" href="http://jcrop-cdn.tapmodo.com/v0.9.12/css/jquery.Jcrop.min.css" type="text/css" />
	<link href="http://edge1u.tapmodo.com/deepliq/jcrop_demos.css" rel="stylesheet" type="text/css" />

	<script src="http://edge1u.tapmodo.com/global/js/jquery.min.js"></script>
  <script src="http://jcrop-cdn.tapmodo.com/v0.9.12/js/jquery.Jcrop.min.js"></script>
	<script src="http://edge1v.tapmodo.com/deepliq/jcrop_demos.js"></script>--%>

    <script type="text/javascript" >

    function enableForm()
    {
        document.getElementById("form1").disabled = false;
    }
    window.onload = enableForm;
 

        $(function () {
            $('#btnGuardar').click(function () {
                $('#GuardarArchivo').show();
                $('#AbrirArchivo').hide();
            });
        });

        $(function () {
            $('#btnAbrir').click(function () {
                $('#GuardarArchivo').hide();
                $('#AbrirArchivo').show();
            });
        });

        $(function () {
            $('#btnCerrarGuardar').click(function () {
                $('#GuardarArchivo').hide();
            });
        });

        $(function () {
            $('#btnCerrarAbrir').click(function () {
                $('#AbrirArchivo').hide();
            });
        });

        //$(window).load(function () {
        //    var pic = $('#imgCrop');

        //    pic.removeAttr("width");
        //    pic.removeAttr("height");

        //    alert(pic.width());
        //    alert(pic.height());
        //});

        //$("#imgCrop").one("load", function () {
        //    var img = this;
        //    setTimeout(function () {
        //        var w = document.querySelector("#<= imgFoto1.ClientID %>").naturalWidth;
        //        alert("W="+w);
        //        imgCrop.width = document.querySelector("#<= imgFoto1.ClientID %>").naturalWidth;
        //        imgCrop.height = document.querySelector("#<= imgFoto1.ClientID %>").naturalHeight;
        //        
        //    }, 0);
        //});

//----------------------------CROP-------------------------------

        //$(function () {
        //    $('#<= imgCrop.ClientID %>').Jcrop({
        //        onSelect: storeCoords
        //    });
        //});

        function storeCoords(c) {

            jQuery('#X').val(c.x);
            jQuery('#Y').val(c.y);
            jQuery('#W').val(c.w);
            jQuery('#H').val(c.h);

        };
//--------------------------------FIN CROP--------------------------
 
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
            image.src = "../UploadedImages/Foto1" + "." + getExt(filename) + '?' + (new Date()).getTime();

            var cropimg = document.getElementById("imgCrop");
            cropimg.src = "../UploadedImages/Foto1" + "." + getExt(filename);// + '?' + (new Date()).getTime();

            cropimg.onload = function () {
                $('#CropDiv').show();
                var jcrop_api = $.Jcrop('#imgCrop');
                var jcrop_store = $('#imgCrop').Jcrop({ onSelect: storeCoords });
            }

        }
        //ASIGNAR IMAGEN 2
        //---------------------------------------------------------------------------
        function AsignarImagen2() {

            var image = document.getElementById("<%= imgFoto2.ClientID %>");
            var filename = document.getElementById("AsyncFileUpload2_ctl02").value;
            image.src = "../UploadedImages/Foto2" + "." + getExt(filename) + '?' + (new Date()).getTime();

            var cropimg = document.getElementById("imgCrop");
            cropimg.src = "../UploadedImages/Foto2" + "." + getExt(filename);// + '?' + (new Date()).getTime();

            cropimg.onload = function () {
                $('#CropDiv').show();
                var jcrop_api = $.Jcrop('#imgCrop');
                var jcrop_store = $('#imgCrop').Jcrop({ onSelect: storeCoords });
            }
            
        }
        //ASIGNAR IMAGEN 3
        //---------------------------------------------------------------------------
        function AsignarImagen3() {

            var image = document.getElementById("<%= imgFoto3.ClientID %>");
            var filename = document.getElementById("AsyncFileUpload3_ctl02").value;
            image.src = "../UploadedImages/Foto3" + "." + getExt(filename) + '?' + (new Date()).getTime();

            var cropimg = document.getElementById("imgCrop");
            cropimg.src = "../UploadedImages/Foto3" + "." + getExt(filename);// + '?' + (new Date()).getTime();

            cropimg.onload = function () {
                $('#CropDiv').show();
                var jcrop_api = $.Jcrop('#imgCrop');
                var jcrop_store = $('#imgCrop').Jcrop({ onSelect: storeCoords });
            }
            
        }
        //ASIGNAR IMAGEN 4
        //---------------------------------------------------------------------------
        function AsignarImagen4() {

            var image = document.getElementById("<%= imgFoto4.ClientID %>");
            var filename = document.getElementById("AsyncFileUpload4_ctl02").value;
            image.src = "../UploadedImages/Foto4" + "." + getExt(filename) + '?' + (new Date()).getTime();

            var cropimg = document.getElementById("imgCrop");
            cropimg.src = "../UploadedImages/Foto4" + "." + getExt(filename);// + '?' + (new Date()).getTime();

            cropimg.onload = function () {
                $('#CropDiv').show();
                var jcrop_api = $.Jcrop('#imgCrop');
                var jcrop_store = $('#imgCrop').Jcrop({ onSelect: storeCoords });
            }
            
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

        function uploadError() 
        {
            alert("error al subir!");
        }

</script>
    
</head>
<body>
<form id="form1" runat="server" disabled="true">
<ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" EnablePageMethods="true" CombineScripts="true" EnableScriptGlobalization="true" runat="server"></ajaxToolkit:ToolkitScriptManager>
<div class="datagrid" style="width: 1150px; height: 1016px; z-index: 2; top: 15px; left: 20px;" id="capa1">

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

       <%-----------------------------------Foto1 ------------------------------------%>

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

     <%-----------------------------------Otros-----------------------------------%>     <%----------------------------------------------------------------------%>
<div style="position: absolute; width: 446px; height: 126px; z-index: 1; left: 743px; top: 791px" id="Div1">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:Button ID="GuardarJPG" runat="server" OnClick="GuardarJPG_Click" Text="Previsualizar JPG" Width="207px" />

            <br />

            <br />

        </ContentTemplate>
    </asp:UpdatePanel>
            
<%--            <div style="width: 25px;height:25px; position: absolute; top: 64px; left: 103px;" id="divBtnG">--%><%--                <button type="button" id="btnGuardar" value="cerrar" class="btn">
                
                </button>--%><%--            </div>--%>
            <button class="btn2" type="button" id="btnGuardar" value="guardar" style="border-width: 1px; border-style: solid; background-image : url('Images/guardar.png'); height: 62px; width: 145px; background-repeat: no-repeat; background-color: #DDDDDD;">

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Guardar

            </button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <button class="btn2" type="button" id="btnAbrir" value="abrir" style="border-width: 1px; border-style: solid; background-image : url('Images/abrir.png'); height: 62px; width: 145px; background-repeat: no-repeat; background-color: #DDDDDD;"> 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Abrir
            </button>

    </div>
<div style="position: absolute; width: 138px; height: 24px; z-index: 4; left: 367px; top: 790px" id="precio" class="auto-style2">
<asp:Label ID="Label1" runat="server" Text="Precio:"></asp:Label>
<asp:TextBox ID="txtPrecio" runat="server" Width="63px" BackColor="#585858" ForeColor="White">0</asp:TextBox>
    </div>
<div style="position: absolute; width: 352px; height: 28px; z-index: 4; left: 367px; top: 823px" id="Div2" class="auto-style2">
<asp:Label ID="Label4" runat="server" Text="Financiacion:" style="text-align: left"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtFinanciacion" runat="server" Width="245px" BackColor="#585858" ForeColor="White">Financiacion: contado 20% de descuento</asp:TextBox>
</div>
</div>

        <%------------------------VENTANA GUARDAR PROYECTO-----------------------------------%>        <%---------Container invisible para abrir GUARDAR los proyectos de titan--------------%>
<div class="datagrid" style="display: none; position: absolute; width: 600px; height: 315px; z-index: 1; left: 600px; top: 918px; text-align: left;" id="GuardarArchivo">
    <table>
        <tbody>
            <tr>
                <td>

        <asp:Label ID="Label2" runat="server" Text="Nombre del proyecto a guardar:"></asp:Label>
&nbsp;  <asp:TextBox ID="txtNombreGuardar" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnGuardarArchivo" runat="server" Text="Guardar Proyecto" OnClick="btnGuardarArchivo_Click" Width="130px"/>
        
        <%-------------------BOTON CERRAR Cierra el "Guardar Archivo"-----------------%>
        <div style="width: 34px;height:34px; position: absolute; top: 8px; left: 532px;" id="CerrarGuardar">
            <button class="" type="button" id="btnCerrarGuardar" value="abrir" style="border-style: hidden; background-image : url('Images/cerrar.jpg'); height: 34px; width: 34px; background-repeat: no-repeat; background-color: #DDDDDD;"> 

            </button>
        </div>

        <br />
        <br />
        <div style="overflow: scroll; height: 250px;">
        <asp:GridView CssClass="mGrid" PagerStyle-CssClass="pgr" ID="GridVListaTitan" runat="server">
            <PagerStyle CssClass="pgr" />
        </asp:GridView>
        </div>
                </td>
            </tr>
        </tbody>
    </table>
</div>

    <%------------------------VENTANA ABRIR PROYECTO--------------------------%>    <%---------Container invisible para abrir archivos de proyecto titan-------%>
<div class="datagrid" style="display: none; position: absolute; width: 600px; height: 315px; z-index: 1; left: 600px; top: 918px; text-align: left;" id="AbrirArchivo">
    <table>
        <tbody>
            <tr>
                <td>

        <div style="width: 130px; position: absolute; top: 8px; left: 351px;">
            <asp:Button ID="btnAbrirProyecto" runat="server" Text="Abrir Proyecto" OnClick="btnAbrirProyecto_Click" Width="130px" />
        </div>

        <%-------------------BOTON CERRAR-----------------%>        <%-------------------BOTON CERRAR Cierra el "Guardar Archivo"-----------------%>
        <div style="width: 34px;height:34px; position: absolute; top: 8px; left: 532px;" id="CerrarAbrir">
            <button class="" type="button" id="btnCerrarAbrir" value="abrir" style="border-style: hidden; background-image : url('Images/cerrar.jpg'); height: 34px; width: 34px; background-repeat: no-repeat; background-color: #DDDDDD;"> 

            </button>
        </div>

        <%--el gridview y el textbox quedan adentro de un update panel, el boton queda afuera del updatepanel--%>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server" Text="Nombre del Proyecto a cargar:"></asp:Label>

                &nbsp;<asp:TextBox ID="txtAbrirProyecto" runat="server"></asp:TextBox>
                <br />
                      <br />
        
        <div style="overflow: scroll; height: 250px;">

        <asp:GridView CssClass="mGrid" PagerStyle-CssClass="pgr" ID="GridVAbrir" runat="server" onselectedindexchanged="CustomersGridView_SelectedIndexChanged" selectedindex="1" autogenerateselectbutton="True"> <selectedrowstyle backcolor="LightCyan" forecolor="DarkBlue" font-bold="true"/>
            <PagerStyle CssClass="pgr" />
        </asp:GridView>
        
        </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        
                </td>
            </tr>
        </tbody>
    </table>
</div>

<%------------------------CROP-------------------------------%><%--<div class="datagrid" style="text-align:center; display: none; width: 1024px; height:768px; position: absolute; top: 0px; left: 0px; z-index: 5;" id="CropDiv" runat="server">--%>
<div class="datagrid" style="text-align:center; display: none; width: 1024px; height:650px; position: absolute; top: 0px; left: 0px; z-index: 5;" id="CropDiv" runat="server">
<table>
    <tr>
        <td>
            <div style="overflow: scroll; width:1000px; height:550px">
             <img id="imgCrop" src="../Images/trans.png" alt="Imagen a cortar"/>
            </div>
      <br />
      <asp:HiddenField ID="X" runat="server" />
      <asp:HiddenField ID="Y" runat="server" />
      <asp:HiddenField ID="W" runat="server" />
      <asp:HiddenField ID="H" runat="server" />
      <asp:Button class="btn" ID="btnCrop" runat="server" Text="Cortar" OnClick="btnCrop_Click" />
       </td>
    </tr>
</table>
 </div>
    <%----------------------FIN CROP-----------------------------%>

</form>
</body>
</html>
