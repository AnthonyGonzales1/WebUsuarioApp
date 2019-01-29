using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Utilities;
using WebUsuarioApp.Utilitarios;
using BLL;

namespace WebUsuarioApp.Registros
{
    public partial class WebFormUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bEliminar.Visible = false;
            }
        }
        
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            var usuarios = repositorio.Buscar(
                Utilitarios.Utils.ToInt(tUsuarioID.Text));
            if (usuarios != null)
            {
                LlenarCampos(usuarios);
                Utilitarios.Utils.ShowToastr(this, "Busqueda exitosa", "Exito");
            }
            else
            {
                Limpiar();
                Utilitarios.Utils.ShowToastr(this,
                    "No se pudo encontrar el presupuesto especificado",
                    "Error", "error");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            bEliminar.Visible = false;
            bGuardar.Text = "Guardar";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            bool paso = false;
            //todo: agregar demas validaciones
            LlenaClase(usuarios);

            if (usuarios.UsuarioId == 0)
                paso = repositorio.Guardar(usuarios);
            else
                paso = repositorio.Modificar(usuarios);

            if (paso)
            {
                MostrarMensaje(TiposMensaje.Success, "Guardado Exitoso!");
                Limpiar();
            }
            else
                MostrarMensaje(TiposMensaje.Error, "No fue posible Guardar");

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();
            int id = Utils.ToInt(tUsuarioID.Text);

            var usuarios = repositorio.Buscar(id);

            if (usuarios == null)
                MostrarMensaje(TiposMensaje.Error, "Registro no encontrado");
            else
                repositorio.Eliminar(id);
        }

        private void Limpiar()
        {
            tUsuarioID.Text = string.Empty;
            tNombres.Text = string.Empty;
            tEmail.Text = string.Empty;
            tClave.Text = string.Empty;
            tClave.Text = string.Empty;
        }

        private void LlenaClase(Usuarios usuario)
        {
            usuario.UsuarioId = Utilitarios.Utils.ToInt(tUsuarioID.Text);
            usuario.Nombres = tNombres.Text;
            usuario.Email = tEmail.Text;
            usuario.Clave = tClave.Text; ;
            usuario.ConfirmarClave = tConfirmarClave.Text;
            //usuario.TipoUsuario = 2;
        }

        public void LlenarCampos(Usuarios usuario)
        {
            tUsuarioID.Text = usuario.UsuarioId.ToString();
            tNombres.Text = usuario.Nombres.ToString();
            tEmail.Text = usuario.Email.ToString();
            tClave.Text = usuario.ConfirmarClave.ToString();
            tConfirmarClave.Text = usuario.ConfirmarClave.ToString();
        }
        
        void MostrarMensaje(TiposMensaje tipo, string mensaje)
        {
            ErrorLabel.Text = mensaje;

            if (tipo == TiposMensaje.Success)
                ErrorLabel.CssClass = "alert-success";
            else
                ErrorLabel.CssClass = "alert-danger";
        }
    }
}