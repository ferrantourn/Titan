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

        }

        protected void btnFoto1_Click(object sender, ImageClickEventArgs e)
        {
            OpenFileDialog F = new OpenFileDialog();
            F.
            F.ShowDialog();
            btnFoto1.ImageUrl = F.FileName;
            //GenerateHTML();
        }
    }
}