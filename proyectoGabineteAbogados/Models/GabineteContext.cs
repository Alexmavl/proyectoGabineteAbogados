using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace proyectoGabineteAbogados.Models
{
    public class GabineteContext : DbContext
    {
        public GabineteContext() : base("name=DatabaseConnection")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Asunto> Asuntos { get; set; }
    }
}