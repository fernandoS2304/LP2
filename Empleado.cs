using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	enum Turno {M,T,N}
    enum Puesto {Panaderoo,JefePanadero,Supervisor,Gerente }
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private Turno turno;
        private Puesto puesto;

        public Empleado(int idEmpleado, string nombre, Turno turno, Puesto puesto)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.Turno = turno;
            this.Puesto = puesto;
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
		}
		}
	}
