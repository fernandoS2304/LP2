using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Natural : Cliente
    {
        private string dni;
        private string nombres;
        private string apellidos;

        public Natural(int id_cliente, int telefono, string direccion, string cuentaBancaria,string dni, string nombres, string apellidos) : base(id_cliente,telefono,direccion,cuentaBancaria)
        {
            this.Dni = dni;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
        }

        public string Dni{
		set{
			this.dni = value;
		}
		get{
			return dni;
		}
	    }
		
		public string Nombres{
		set{
			this.nombres = value;
		}
		get{
			return nombres;
		}
	    }
		
        public string Apellidos{
		set{
			this.apellidos = value;
		}
		get{
			return apellidos;
		}
	    }
    }

