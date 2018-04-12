using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		}	
        }
	}
