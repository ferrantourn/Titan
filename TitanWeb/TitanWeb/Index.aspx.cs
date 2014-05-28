using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using SD = System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace TitanWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                HttpContext context = HttpContext.Current;
                if (!Page.IsPostBack)
                {
                    foreach (FileInfo f in new DirectoryInfo(Server.MapPath("UploadedImages/")).GetFiles("*.*"))
                    {
                        f.Delete();
                    }
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/Fondo.png"));
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/FondoPrecio.png"));
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/Foto1.png"));
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/Foto2.png"));
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/Foto3.png"));
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/Foto4.png"));
                    File.Copy(Server.MapPath("~/Images/trans.png"), Server.MapPath("~/UploadedImages/FondoLogo.png"));

                    AutoliderContainer c = new AutoliderContainer();
                    //HttpContext context = HttpContext.Current;
                    context.Session["Container"] = c;
                    Persistencia p = new Persistencia();
                    p.AbrirProyectoVacio(c);

                    GridVListaTitan.DataSource = p.ListadoArchivosTitan();
                    GridVListaTitan.DataBind();
                    GridVAbrir.DataSource = p.ListadoArchivosTitan();
                    GridVAbrir.DataBind();



                    if (Request.QueryString["abrir"] != null)
                    {
                        Persistencia P = new Persistencia();
                        AutoliderContainer c2 = (AutoliderContainer)context.Session["Container"];
                        P.AbrirProyectoAutolider(Request.QueryString["abrir"].ToString(), c2);
                        imgFoto1.ImageUrl = "";
                        imgFoto2.ImageUrl = "";
                        imgFoto3.ImageUrl = "";
                        imgFoto4.ImageUrl = "";

                        //cargo en la página los valores obtenidos del nuevo c
                        imgFoto1.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c2.SFoto1.ToString()) + "?" + DateTime.Now.Ticks.ToString());
                        imgFoto2.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c2.SFoto2.ToString()) + "?" + DateTime.Now.Ticks.ToString());
                        imgFoto3.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c2.SFoto3.ToString()) + "?" + DateTime.Now.Ticks.ToString());
                        imgFoto4.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c2.SFoto4.ToString()) + "?" + DateTime.Now.Ticks.ToString());
                        txtCilindrada.Text = c2.SCilindrada;
                        txtDescripcion.Text = c2.SDescripcionMultiLine;
                        txtModelo.Text = c2.SModelo;
                        txtMotor.Text = c2.SMotor;
                        txtPrecio.Text = c2.SPrecio;
                        txtFinanciacion.Text = c2.SFinanciacion;
                        txtNombreGuardar.Text = Path.GetFileNameWithoutExtension(Request.QueryString["abrir"].ToString());
                    }
                }
                else
                {
                    context.Session["cropped1"] = false;
                    context.Session["cropped2"] = false;
                    context.Session["cropped3"] = false;
                    context.Session["cropped4"] = false;
                }
            }
            catch
            {
            }


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
                            HttpContext context = HttpContext.Current;
                            if (((Boolean)context.Session["cropped1"]) == false)//bandera anti overwrite - impide que el async borre la imagen croppeada.
                            {
                                AsyncFileUpload1.SaveAs(SaveFileTo);
                            }
                            else
                            {
                                context.Session["cropped1"] = false;
                            }

                                imgFoto1.ImageUrl = "~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.'));
                                AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                                c.SFoto1 = new Uri(Server.MapPath("~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.'))));
                                context.Session["WorkingImage"] = Server.MapPath(imgFoto1.ImageUrl);
                                context.Session["cropped1"] = true;
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
                            HttpContext context = HttpContext.Current;
                            if (((Boolean)context.Session["cropped2"]) == false)//bandera anti overwrite - impide que el async borre la imagen croppeada.
                            {
                                AsyncFileUpload2.SaveAs(SaveFileTo);
                            }
                            else
                            {
                                context.Session["cropped2"] = false;
                            }

                            imgFoto2.ImageUrl = "~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'));
                            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                            c.SFoto2 = new Uri(Server.MapPath("~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'))));
                            context.Session["WorkingImage"] = Server.MapPath(imgFoto2.ImageUrl);
                            context.Session["cropped2"] = true;
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
                            HttpContext context = HttpContext.Current;
                            if (((Boolean)context.Session["cropped3"]) == false)//bandera anti overwrite - impide que el async borre la imagen croppeada.
                            {
                                AsyncFileUpload3.SaveAs(SaveFileTo);
                            }
                            else
                            {
                                context.Session["cropped3"] = false;
                            }

                            imgFoto3.ImageUrl = "~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.'));
                            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                            c.SFoto3 = new Uri(Server.MapPath("~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.'))));
                            context.Session["WorkingImage"] = Server.MapPath(imgFoto3.ImageUrl);
                            context.Session["cropped3"] = true;
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
                            HttpContext context = HttpContext.Current;
                            if (((Boolean)context.Session["cropped4"]) == false)//bandera anti overwrite - impide que el async borre la imagen croppeada.
                            {
                                AsyncFileUpload4.SaveAs(SaveFileTo);
                            }
                            else
                            {
                                context.Session["cropped4"] = false;
                            }

                            imgFoto4.ImageUrl = "~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.'));
                            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                            c.SFoto4 = new Uri(Server.MapPath("~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.'))));
                            context.Session["WorkingImage"] = Server.MapPath(imgFoto4.ImageUrl);
                            context.Session["cropped4"] = true;
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
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = ((AutoliderContainer)context.Session["Container"]);
                            c.SFondoPlantilla = new Uri(Server.MapPath("~/UploadedImages/Fondo" + filename.Substring(filename.LastIndexOf('.'))));
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
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = ((AutoliderContainer)context.Session["Container"]);
                            c.SLogo = new Uri(Server.MapPath("~/UploadedImages/FotoLogo" + filename.Substring(filename.LastIndexOf('.'))));
                            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
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
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = ((AutoliderContainer)context.Session["Container"]);
                            c.SFondoPrecio = new Uri(Server.MapPath("~/UploadedImages/FondoPrecio" + filename.Substring(filename.LastIndexOf('.'))));
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

        protected void btnCrop_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            string ImageName = context.Session["WorkingImage"].ToString();
            //string ImageName = imgCrop.ImageUrl;
            int w = Convert.ToInt32(W.Value);
            int h = Convert.ToInt32(H.Value);
            int x = Convert.ToInt32(X.Value);
            int y = Convert.ToInt32(Y.Value);

            byte[] CropImage = Crop(ImageName, w, h, x, y);

            using (MemoryStream ms = new MemoryStream(CropImage, 0, CropImage.Length))
            {
                ms.Write(CropImage, 0, CropImage.Length);
                using (SD.Image CroppedImage = SD.Image.FromStream(ms, true))
                {
                    string SaveTo = ImageName;
                    if (File.Exists(ImageName))
                    {
                        File.Delete(ImageName);
                    }
                    CroppedImage.Save(SaveTo, CroppedImage.RawFormat);
                    context.Session["cropped1"] = true;
                    context.Session["cropped2"] = true;
                    context.Session["cropped3"] = true;
                    context.Session["cropped4"] = true;
                }
            }
        }

        static byte[] Crop(string Img, int Width, int Height, int X, int Y)
        {
            try
            {
                using (SD.Image OriginalImage = SD.Image.FromFile(Img))
                {
                    using (SD.Bitmap bmp = new SD.Bitmap(Width, Height))
                    {
                        bmp.SetResolution(OriginalImage.HorizontalResolution, OriginalImage.VerticalResolution);
                        using (SD.Graphics Graphic = SD.Graphics.FromImage(bmp))
                        {
                            Graphic.SmoothingMode = SmoothingMode.AntiAlias;
                            Graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            Graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            Graphic.DrawImage(OriginalImage, new SD.Rectangle(0, 0, Width, Height), X, Y, Width, Height, SD.GraphicsUnit.Pixel);

                            MemoryStream ms = new MemoryStream();
                            bmp.Save(ms, OriginalImage.RawFormat);
                            return ms.GetBuffer();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        protected void GuardarJPG_Click(object sender, EventArgs e)
        {
            try
            {
                HttpContext context = HttpContext.Current;
                AutoliderContainer c = ((AutoliderContainer)context.Session["Container"]);
                c.SCilindrada = txtCilindrada.Text;
                c.SDescripcionMultiLine = txtDescripcion.Text;
                c.SModelo = txtModelo.Text;
                c.SMotor = txtMotor.Text;
                c.SPrecio = txtPrecio.Text;
                c.SFinanciacion = txtFinanciacion.Text;

                AutoliderHTML A = new AutoliderHTML();
                Persistencia P = new Persistencia();
                string text = A.GenerateHTML(c);

                P.GuardarHTML(text, Server.MapPath("~/index.html"));
                P.GuardarJPG(Server.MapPath("~/index.html"), Server.MapPath("~/index.jpg"));

                string strUrl="/index.jpg";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", "window.open('" + strUrl + "','_blank')", true);


            }
            catch
            {

            }
        }


        //-----------------en desuso:-------------------------
        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            Persistencia P = new Persistencia();
            HttpContext context = HttpContext.Current;
            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
            c.SModelo = txtModelo.Text;
            c.SMotor = txtMotor.Text;
            c.SDescripcionMultiLine = txtDescripcion.Text;
            c.SCilindrada = txtCilindrada.Text;
            c.SPrecio = txtPrecio.Text;
            c.SFinanciacion = txtFinanciacion.Text;
            P.GuardarProyectoAutolider(txtNombreGuardar.Text, c);
            
            AutoliderHTML A = new AutoliderHTML();
            string text = A.GenerateHTML(c);

        //    P.GuardarHTML(text, Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".html"));
        //    P.GuardarJPG(Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".html"), "~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".jpg");
        }

        protected void btnAbrirProyecto_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx?abrir=" + txtAbrirProyecto.Text);
        }

        protected void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            Persistencia P = new Persistencia();
            HttpContext context = HttpContext.Current;
            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
            c.SModelo = txtModelo.Text;
            c.SMotor = txtMotor.Text;
            c.SDescripcionMultiLine = txtDescripcion.Text;
            c.SCilindrada = txtCilindrada.Text;
            c.SPrecio = txtPrecio.Text;
            c.SFinanciacion = txtFinanciacion.Text;

            P.GuardarProyectoAutolider(txtNombreGuardar.Text, c);
            AutoliderHTML A = new AutoliderHTML();
            string text = A.GenerateHTML(c);

            P.GuardarHTML(text, Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".html"));
            P.GuardarJPG(Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".html"), Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".jpg"));

            GridVListaTitan.DataSource = P.ListadoArchivosTitan();
            GridVListaTitan.DataBind();
            GridVAbrir.DataSource = P.ListadoArchivosTitan();
            GridVAbrir.DataBind();
            Response.Redirect("Index.aspx");

        }
        public void CustomersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAbrirProyecto.Text = GridVAbrir.SelectedRow.Cells[1].Text;
        }


    }
}