using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Permiso

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


        public int IdPermiso{

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

