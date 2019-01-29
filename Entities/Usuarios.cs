using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            ConfirmarClave = string.Empty;
        }

        public Usuarios(int usuarioId, string nombres, string email, string clave, string confirmarClave)
        {
            UsuarioId = usuarioId;
            Nombres = nombres;
            Email = email;
            Clave = clave;
            ConfirmarClave = confirmarClave;
        }
    }
}
