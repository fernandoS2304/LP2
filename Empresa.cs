using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaderia
{
    public class Empresa : Cliente
    {
        private string ruc;
        private string nombreEmpresa;

        public Empresa(string ruc, string nombreEmpresa)
        {
            this.Ruc = ruc;
            this.NombreEmpresa = nombreEmpresa;
        }

        public string Ruc { get => ruc; set => ruc = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
    }
}
