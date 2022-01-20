using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R10_EFconASPyMVC.Models
{
    public class Trabajador
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int TelefonoContacto { get; set; }

        public int EmpresaId  { get; set; }

        public Empresa Empresa { get; set; }


    }
}
