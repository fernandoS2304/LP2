using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
   public class CuentaUsuario
=======
    class CuentaUsuario
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
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
<<<<<<< HEAD

	    public Permiso Perm{
	    	get{
	    		return permiso;
	    	}
	    	set{
	    		permiso = value;
	    	}
	    }
		
		public void verificacionDatos(string contras){
		}
		
		public void registrarUsario(string nombreUsuario,string contrasenha){
		}
		
=======
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
        
    }

