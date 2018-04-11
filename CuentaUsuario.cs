using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaderia
{
    class CuentaUsuario
    {
        private int idUsario;
        private string nombreUsuario;
        private string password;
        private Permiso permiso;

        public CuentaUsuario(int idUsario, string nombreUsuario, string password, Permiso permiso)
        {
            this.IdUsario = idUsario;
            this.NombreUsuario = nombreUsuario;
            this.Password = password;
            this.Permiso = permiso;
        }

        public int IdUsario { get => idUsario; set => idUsario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        internal Permiso Permiso { get => permiso; set => permiso = value; }
    }
}
