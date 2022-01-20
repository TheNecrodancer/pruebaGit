using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace R10_EFconASPyMVC.Models
{

    public class Empresa
    {
        //PROPIEDADES DE LA CLASE

        public int Id { get; set; }

        public int NumeroSeguridad { get; set; }

        public String Nombre { get; set; }

        public List<Trabajador> Trabajadores { get; set; }

    }
}
