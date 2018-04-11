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

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CuentaBancaria { get => cuentaBancaria; set => cuentaBancaria = value; }
    }
}
