using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


<<<<<<< HEAD
	
=======
	enum Turno {M,T,N}
    enum Puesto {Panaderoo,JefePanadero,Supervisor,Gerente }
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private turno turnoEmpleado;
        private puesto puestoEmpleado;

        public Empleado(int idEmpleado, string nombre, turno turno, puesto puesto)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.turnoEmpleado = turno;
            this.puestoEmpleado = puesto;
        }

        public int IdEmpleado{
		set{
			this.idEmpleado = value;
		}
		get{
			return idEmpleado;
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
		
<<<<<<< HEAD
        public turno TurnoEmpleado{
		set{
			this.turnoEmpleado = value;
	    }
		get{
			return turnoEmpleado;
		}
		}
		
		public puesto PuestoEmpleado{
		set{
			this.puestoEmpleado = value;
	    }
		get{
			return puestoEmpleado;
=======
        public Turno Turno{
		get{
			this.turno = value;
	    }
		get{
			return turno;
		}
		}
		
		public Puesto Puesto{
		get{
			this.puesto = value;
	    }
		get{
			return puesto;
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
		}
		}
	}
