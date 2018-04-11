using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaderia
{   enum Turno {M,T,N}
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

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Turno Turno { get => turno; set => turno = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
    }
}
