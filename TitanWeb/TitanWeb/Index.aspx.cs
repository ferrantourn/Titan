using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace TitanWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["PlantillaActual"] = "0";
        }


        protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUpload1.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUpload1.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUpload1.SaveAs(SaveFileTo);
                            imgFoto1.ImageUrl = "~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }

        protected void AsyncFileUpload2_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUpload2.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUpload2.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUpload2.SaveAs(SaveFileTo);
                            imgFoto2.ImageUrl = "~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }

        protected void AsyncFileUpload3_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUpload3.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUpload3.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUpload3.SaveAs(SaveFileTo);
                            imgFoto3.ImageUrl = "~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }

        protected void AsyncFileUpload4_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUpload4.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUpload4.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUpload4.SaveAs(SaveFileTo);
                            imgFoto4.ImageUrl = "~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }
        protected void AsyncFileUploadFondo_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUploadFondo.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUploadFondo.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/Fondo" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUploadFondo.SaveAs(SaveFileTo);
                            //imgFotoFondo.ImageUrl = "~/UploadedImages/Fondo" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }

        protected void AsyncFileUploadLogo_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUploadLogo.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUploadLogo.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/FotoLogo" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUploadLogo.SaveAs(SaveFileTo);
                            //imgFotoLogo.ImageUrl = "~/UploadedImages/FotoLogo" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }

        protected void AsyncFileUploadFondoPrecio_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            try
            {
                if (AsyncFileUploadFondoPrecio.HasFile)
                {
                    //EL ARCHIVO NO PUEDE SER MAYOR A 1MB.
                    //----------------------------------------
                    if (Convert.ToInt32(e.FileSize) <= 1000000)
                    {
                        string filename = AsyncFileUploadFondoPrecio.FileName;

                        //SI ES UNA EXTENSION VALIDA.
                        //---------------------------
                        if ((filename.EndsWith(".jpg")) || (filename.EndsWith(".JPG")) || (filename.EndsWith(".PNG")) || (filename.EndsWith(".png"))
                             || (filename.EndsWith(".jpeg")) || (filename.EndsWith(".JPEG")))
                        {
                            //SALVAMOS LA IMAGEN A UNA CARPETA
                            //-------------------------------
                            string SaveFileTo = Server.MapPath("~/UploadedImages/FondoPrecio" + filename.Substring(filename.LastIndexOf('.')));
                            AsyncFileUploadFondoPrecio.SaveAs(SaveFileTo);
                            //imgFotoFondoPrecio.ImageUrl = "~/UploadedImages/FondoPrecio" + filename.Substring(filename.LastIndexOf('.'));
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }

        protected void GuardarJPG_Click(object sender, EventArgs e)
        {
            AutoliderContainer c = new AutoliderContainer();
            c.SCilindrada = txtCilindrada.Text;
            c.SDescripcionMultiLine = txtDescripcion.Text;
            //c.SMarca
            c.SModelo = txtModelo.Text;
            c.SMotor = txtMotor.Text;
            c.SPrecio = txtPrecio.Text;
            c.SFoto1 = new Uri(imgFoto1.ImageUrl);
            //c.SFoto2 = new Uri(imgFoto2.ImageUrl);
            //c.SFoto3 = new Uri(imgFoto3.ImageUrl);
            //c.SFoto4 = new Uri(imgFoto4.ImageUrl);
            //c.SLogo = new Uri(imgFoto4.ImageUrl);
        }
    }
}