using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Empresa : Cliente
    {
        private string ruc;
        private string nombreEmpresa;

        public Empresa(int id_cliente, int telefono, string direccion, string cuentaBancaria,string ruc, string nombreEmpresa ): base(id_cliente,telefono,direccion,cuentaBancaria)
        {
            this.Ruc = ruc;
            this.NombreEmpresa = nombreEmpresa;
        }

        public string Ruc{
		set{
			this.ruc = value;
		}
		get{
			return ruc;
		}
	    }
		
		public string NombreEmpresa{
		set{
			this.nombreEmpresa = value;
		}
		get{
			return nombreEmpresa;
		}
	    }
        
    }

