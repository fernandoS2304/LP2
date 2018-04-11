using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaderia
{
    class Permiso
    {
        private int idPermiso;
        private string nombre;
        private string descripcion;

        public Permiso(int idPermiso, string nombre, string descripcion)
        {
            this.IdPermiso = idPermiso;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdPermiso { get => idPermiso; set => idPermiso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
