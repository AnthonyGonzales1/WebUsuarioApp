using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUsuarioApp.Consultas
{
    public partial class WebConsultUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bBuscar_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Usuarios, bool>> filtro = x => true;
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();

            int id;
            switch (CamposDropDownList.SelectedIndex)
            {
                case 0://ID
                    id = Utilitarios.Utils.ToInt(tFiltro.Text);
                    filtro = c => c.UsuarioId == id;
                    break;
                case 1:// nombre
                    filtro = c => c.Nombres.Contains(tFiltro.Text);
                    break;
                case 2:// nombre
                    filtro = c => c.Email.Contains(tFiltro.Text);
                    break;
            }

            DatosGridView.DataSource = repositorio.GetList(filtro);
            DatosGridView.DataBind();
        }
    }
}