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

                            imgFoto1.ImageUrl = SaveFileTo;
                        }
                    }
                }
            }
            catch
            {
                txtModelo.Text = "Error";
            }
        }
    }
}