using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


<<<<<<< HEAD
    public class Permiso
=======
    class Permiso
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
    {
        private int idPermiso;
        private string nombre;
        private string descripcion;

        public Permiso(){}

        public Permiso(int idPermiso, string nombre, string descripcion)
        {
            this.idPermiso = idPermiso;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

<<<<<<< HEAD
        public int IdPermiso{
=======
        public string IdPermiso{
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
		set{
			this.idPermiso = value;
		}
		get{
			return idPermiso;
		}
	    }
        
		public string Nombre{
		set{
			this.nombre = value;
		}
		get{
			return nombre;
		}
	    }
		
        public string Descripcion{
		set{
			this.descripcion = value;
		}
		get{
			return descripcion;
		}
	    }
    }

