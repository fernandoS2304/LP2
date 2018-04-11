using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaderia
{
    public class Cliente
    {
        private int id_cliente;
        private int telefono;
        private string direccion;
        private string cuentaBancaria;

        public Cliente(int id_cliente, int telefono, string direccion, string cuentaBancaria)
        {
            this.Id_cliente = id_cliente;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.CuentaBancaria = cuentaBancaria;
        }

        public int id_cliente{
		set{
			this.id_cliente = value;
		}
		get{
			return id_cliente;
		}
		}
		
		public int telefono{
		set{
			this.telefono = value;
		}
		get{
			return telefono;
		}
		}
		
		public string direccion{
		set{
			this.direccion = value;
		}
		get{
			return direccion;
		}
	    }
		
		public string cuentaBancaria{
		set{
			this.cuentaBancaria = value;
		}
		get{
			return cuentaBancaria;
		}
		}
}
