using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebUsuarioApp
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        private RepositorioBase<Usuarios> BLL = new RepositorioBase<Usuarios>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bIniciar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            Usuarios user = new Usuarios();

            filtrar = t => t.Nombres.Equals(tUsuarios.Text) && t.Clave.Equals(tClave.Text);
            if (BLL.GetList(filtrar).Count() != 0)
                FormsAuthentication.RedirectFromLoginPage(user.Nombres, true);
            else
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Usuario o Contrasena Incorrecto');", addScriptTags: true);
        }
    }
}