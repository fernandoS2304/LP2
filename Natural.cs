using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaderia
{
    class Natural : Cliente
    {
        private string dni;
        private string nombres;
        private string apellidos;

        public Natural(string dni, string nombres, string apellidos: base(id_cliente,telefono,direccion,cuentaBancaria))
        {
            this.Dni = dni;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
