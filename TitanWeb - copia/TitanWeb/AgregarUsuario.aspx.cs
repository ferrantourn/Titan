using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TitanWeb
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            if (context.Session["Logueado"] == null || (bool)context.Session["Logueado"] == false)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((txtPassword.Text == txtPassword2.Text) && (txtNombreUsuario.Text!="") && (txtPassword.Text!=""))
            {
                Persistencia p = new Persistencia();
                bool agregado = p.GuardarUsuarioNew(txtNombreUsuario.Text, txtPassword.Text);
                if (agregado)
                {
                    txtError.Text = "Se ha agregado el usuario";
                }
                else
                {
                    txtError.Text = "Error, el usuario ya existe";
                }
            }
            else
            {
                txtError.Text = "Error, los passwords no coinciden o los campos estan vacíos";
            }
            
        }



    }
}