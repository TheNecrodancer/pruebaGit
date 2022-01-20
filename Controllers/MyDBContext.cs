using Microsoft.EntityFrameworkCore;//usamos la clase EntityFrameworkCore
using R10_EFconASPyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasApi.Models
{
    public class MyDBContext: DbContext
    {
        public MyDBContext (DbContextOptions<MyDBContext> options) 
            : base(options)
        {

        }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Trabajador> Trabajador { get; set; }

    }
}
