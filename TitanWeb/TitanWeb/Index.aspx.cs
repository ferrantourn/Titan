using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace TitanWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
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
                    HttpContext context = HttpContext.Current;
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
                        txtNombreGuardar.Text = Path.GetFileNameWithoutExtension(Request.QueryString["abrir"].ToString());
                    }
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
                            AsyncFileUpload1.SaveAs(SaveFileTo);
                            imgFoto1.ImageUrl = "~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.'));
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                            c.SFoto1 = new Uri(Server.MapPath("~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.'))));
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
                            imgFoto2.ImageUrl = "";
                            imgFoto2.ImageUrl = "~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'));
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                            c.SFoto2 = new Uri(Server.MapPath("~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'))));
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
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
                            c.SFoto3 = new Uri(Server.MapPath("~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.'))));
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
                            imgFoto4.ImageUrl = ResolveUrl("~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.')));
                            HttpContext context = HttpContext.Current;
                            AutoliderContainer c = ((AutoliderContainer)context.Session["Container"]);
                            c.SFoto4 = new Uri(Server.MapPath("~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.'))));
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

        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {//en desuso
            Persistencia P = new Persistencia();
            HttpContext context = HttpContext.Current;
            AutoliderContainer c = (AutoliderContainer)context.Session["Container"];
            c.SModelo = txtModelo.Text;
            c.SMotor = txtMotor.Text;
            c.SDescripcionMultiLine = txtDescripcion.Text;
            c.SCilindrada = txtCilindrada.Text;
            c.SPrecio = txtPrecio.Text;
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

            P.GuardarProyectoAutolider(txtNombreGuardar.Text, c);
            AutoliderHTML A = new AutoliderHTML();
            string text = A.GenerateHTML(c);

            P.GuardarHTML(text, Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".html"));
            P.GuardarJPG(Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".html"), Server.MapPath("~/" + Path.GetFileNameWithoutExtension(txtNombreGuardar.Text) + ".jpg"));

            GridVListaTitan.DataSource = P.ListadoArchivosTitan();
            GridVListaTitan.DataBind();
            GridVAbrir.DataSource = P.ListadoArchivosTitan();
            GridVAbrir.DataBind();
        }
        public void CustomersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAbrirProyecto.Text = GridVAbrir.SelectedRow.Cells[1].Text;
        }
    }
}