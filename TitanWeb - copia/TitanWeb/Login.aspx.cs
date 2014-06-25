using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TitanWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Persistencia p = new Persistencia();
            bool logueado = p.LoginUsuarioNewNoEnc(txtNombreUsuario.Text, txtPassword.Text);
            HttpContext context = HttpContext.Current;
            context.Session["Logueado"] = logueado;
            

            if (logueado == true)
            {
                LogicaErrores.GuardarError("Usuario " + txtNombreUsuario.Text + " logueado con éxito" , DateTime.Now);
                Response.Redirect("Index.aspx");
            }
            else
            {
                LogicaErrores.GuardarError("Error Login: " + txtNombreUsuario.Text, DateTime.Now);
                txtError.Text = "Error";
            }

        }
    }
}