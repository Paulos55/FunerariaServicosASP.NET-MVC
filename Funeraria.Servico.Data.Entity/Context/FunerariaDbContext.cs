using Funeraria.Servico.Data.Entity.TypeConfiguration;
using Funeraria.Servico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria.Servico.Data.Entity.Context
{
    public class FunerariaDbContext : DbContext
    {
        public DbSet<ServicoPrestado> servicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServicoTypeConfiguration());
        }
    }
}
