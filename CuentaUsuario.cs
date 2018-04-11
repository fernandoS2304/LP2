using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class CuentaUsuario
    {
        private int idUsario;
        private string nombreUsuario;
        private string password;
        private Permiso permiso;

        public CuentaUsuario(int idUsario, string nombreUsuario, string password, Permiso permiso)
        {
            this.idUsario = idUsario;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.permiso = permiso;
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

	    public Permiso Perm{
	    	get{
	    		return permiso;
	    	}
	    	set{
	    		permiso = value;
	    	}
	    }
        
    }

