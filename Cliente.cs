using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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

<<<<<<< HEAD
        public int Id_cliente{
=======
        public int id_cliente{
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
		set{
			this.id_cliente = value;
		}
		get{
			return id_cliente;
		}
		}
		
<<<<<<< HEAD
		public int Telefono{
=======
		public int telefono{
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
		set{
			this.telefono = value;
		}
		get{
			return telefono;
		}
		}
		
<<<<<<< HEAD
		public string Direccion{
=======
		public string direccion{
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
		set{
			this.direccion = value;
		}
		get{
			return direccion;
		}
	    }
		
<<<<<<< HEAD
		public string CuentaBancaria{
=======
		public string cuentaBancaria{
>>>>>>> 7f0dc62dc82c8ea4ce7b9b11c5c971f9f7a7b3f3
		set{
			this.cuentaBancaria = value;
		}
		get{
			return cuentaBancaria;
		}
		}
}
