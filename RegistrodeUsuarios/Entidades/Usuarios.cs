using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeUsuarios.Entidades
{
  public  class Usuarios
    {
        [Key]
        public int Usuarioid { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuarios()
        {
            Usuarioid = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            NombreDeUsuario = string.Empty;
            Contrasena = string.Empty;
        }
    }
}
