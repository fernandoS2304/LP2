using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int IdUsario{
		set{
			this.idUsario = value;
		}
		get{
			return idUsario;
		}
		}
		
		public string NombreUsuario{
		set{
			this.nombreUsuario = value;
		}
		get{
			return nombreUsuario;
		}
	    }
		
		public string Password{
		set{
			this.password = value;
		}
		get{
			return password;
		}
	    }
        
    }

