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
                c.SFondoPlantilla = new Uri(Server.MapPath("~/UploadedImages/Fondo.png"));
                c.SFondoPrecio = new Uri(Server.MapPath("~/UploadedImages/FondoPrecio.png"));
                c.SFoto1 = new Uri(Server.MapPath("~/UploadedImages/Foto1.png"));
                c.SFoto2 = new Uri(Server.MapPath("~/UploadedImages/Foto2.png"));
                c.SFoto3 = new Uri(Server.MapPath("~/UploadedImages/Foto3.png"));
                c.SFoto4 = new Uri(Server.MapPath("~/UploadedImages/Foto4.png"));
                c.SLogo = new Uri(Server.MapPath("~/UploadedImages/FondoLogo.png"));
                    
                ViewState["Container"] = c;

                    Persistencia p = new Persistencia();
                    GridVListaTitan.DataSource = p.ListadoArchivosTitan();
                    GridVListaTitan.DataBind();
                    GridVAbrir.DataSource = p.ListadoArchivosTitan();
                    GridVAbrir.DataBind();

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
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "BorrarImagen1", "Borrar1()", true);
                            Random random = new Random();
                            int randomNumber = random.Next(0, 1000);
                            imgFoto1.ImageUrl = "~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.')) + "?" + randomNumber.ToString();

                            ((AutoliderContainer)ViewState["Container"]).SFoto1 = new Uri(Server.MapPath("~/UploadedImages/Foto1" + filename.Substring(filename.LastIndexOf('.'))));
                            
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
                            imgFoto1.ImageUrl = "";
                            imgFoto2.ImageUrl = "~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'));

                            ((AutoliderContainer)ViewState["Container"]).SFoto2 = new Uri(Server.MapPath("~/UploadedImages/Foto2" + filename.Substring(filename.LastIndexOf('.'))));
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
                            imgFoto1.ImageUrl = "";
                            imgFoto3.ImageUrl = "~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.'));
                            ((AutoliderContainer)ViewState["Container"]).SFoto3 = new Uri(Server.MapPath("~/UploadedImages/Foto3" + filename.Substring(filename.LastIndexOf('.'))));
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
                            ((AutoliderContainer)ViewState["Container"]).SFoto4 = new Uri(Server.MapPath("~/UploadedImages/Foto4" + filename.Substring(filename.LastIndexOf('.'))));
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
                            ((AutoliderContainer)ViewState["Container"]).SFondoPlantilla = new Uri(Server.MapPath("~/UploadedImages/Fondo" + filename.Substring(filename.LastIndexOf('.'))));
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
                            ((AutoliderContainer)ViewState["Container"]).SLogo = new Uri(Server.MapPath("~/UploadedImages/FotoLogo" + filename.Substring(filename.LastIndexOf('.'))));
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
                            ((AutoliderContainer)ViewState["Container"]).SFondoPrecio = new Uri(Server.MapPath("~/UploadedImages/FondoPrecio" + filename.Substring(filename.LastIndexOf('.'))));
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

                ((AutoliderContainer)ViewState["Container"]).SCilindrada = txtCilindrada.Text;
                ((AutoliderContainer)ViewState["Container"]).SDescripcionMultiLine = txtDescripcion.Text;
                ((AutoliderContainer)ViewState["Container"]).SModelo = txtModelo.Text;
                ((AutoliderContainer)ViewState["Container"]).SMotor = txtMotor.Text;
                ((AutoliderContainer)ViewState["Container"]).SPrecio = txtPrecio.Text;

                AutoliderHTML A = new AutoliderHTML();
                string text = A.GenerateHTML(((AutoliderContainer)ViewState["Container"]));
                Persistencia P = new Persistencia();
                P.GuardarHTML(text, Server.MapPath("~/index.html"));
                P.GuardarJPG(Server.MapPath("~/index.html"), Server.MapPath("~/index.jpg"));

                VinculoJPG.NavigateUrl = "~/index.jpg";
                VinculoJPG.Text = Server.MapPath("~/index.jpg").ToString();


            }
            catch
            {
 
            }
        }

        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            Persistencia P = new Persistencia();
            AutoliderContainer c = (AutoliderContainer)ViewState["Container"];
            c.SModelo = txtModelo.Text;
            c.SMotor = txtMotor.Text;
            c.SDescripcionMultiLine = txtDescripcion.Text;
            c.SCilindrada = txtCilindrada.Text;
            c.SPrecio = txtPrecio.Text;
            P.GuardarProyectoAutolider("proyecto", c);
        }

        protected void btnAbrirProyecto_Click(object sender, EventArgs e)
        {
            Persistencia P = new Persistencia();
            AutoliderContainer c = (AutoliderContainer)ViewState["Container"];
            P.AbrirProyectoAutolider(txtAbrirProyecto.Text, c);
            imgFoto1.ImageUrl = "";
            imgFoto2.ImageUrl = "";
            imgFoto3.ImageUrl = "";
            imgFoto4.ImageUrl = "";
                        
            //cargo en la página los valores obtenidos del nuevo c
            imgFoto1.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c.SFoto1.ToString()));
            imgFoto2.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c.SFoto2.ToString()));
            imgFoto3.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c.SFoto3.ToString()));
            imgFoto4.ImageUrl = this.ResolveUrl("~/UploadedImages/" + Path.GetFileName(c.SFoto4.ToString()));
            txtCilindrada.Text = c.SCilindrada;
            txtDescripcion.Text = c.SDescripcionMultiLine;
            txtModelo.Text = c.SModelo;
            txtMotor.Text = c.SMotor;
            txtPrecio.Text = c.SPrecio;
        }

        protected void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            Persistencia P = new Persistencia();
            AutoliderContainer c = (AutoliderContainer)ViewState["Container"];
            c.SModelo = txtModelo.Text;
            c.SMotor = txtMotor.Text;
            c.SDescripcionMultiLine = txtDescripcion.Text;
            c.SCilindrada = txtCilindrada.Text;
            c.SPrecio = txtPrecio.Text;
            P.GuardarProyectoAutolider(txtNombreGuardar.Text, c);
            GridVListaTitan.DataSource = P.ListadoArchivosTitan();
            GridVListaTitan.DataBind();
            GridVAbrir.DataSource = P.ListadoArchivosTitan();
            GridVAbrir.DataBind(); 
        }
        public void CustomersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAbrirProyecto.Text = GridVAbrir.SelectedRow.Cells[1].Text;
            //Persistencia P = new Persistencia();
            //AutoliderContainer c = (AutoliderContainer)ViewState["Container"];
            //c.SModelo = txtModelo.Text;
            //c.SMotor = txtMotor.Text;
            //c.SDescripcionMultiLine = txtDescripcion.Text;
            //c.SCilindrada = txtCilindrada.Text;
            //c.SPrecio = txtPrecio.Text;
            //P.GuardarProyectoAutolider(GridVAbrir.SelectedRow.Cells[1].Text, c);
            //GridVListaTitan.DataSource = P.ListadoArchivosTitan();
            //GridVListaTitan.DataBind();
            //GridVAbrir.DataSource = P.ListadoArchivosTitan();
            //GridVAbrir.DataBind();
         }
    }
}