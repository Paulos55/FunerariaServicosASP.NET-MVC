using Funeraria.Servico.Dominio;
using Funeraria.Servico.Generic.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria.Servico.Data.Entity.TypeConfiguration
{
    class ServicoTypeConfiguration : FunerariaEntityAbstractConfig<ServicoPrestado>
    {
        protected override void ConfigForeignKey()
        {
        }

        protected override void ConfigPrimaryKey()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigTableCamp()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Tipo)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Tipo");

            Property(p => p.Data)
                .IsRequired()
                .HasColumnName("Data");

            Property(p => p.Valor)
                .IsRequired()
                .HasColumnName("Valor");

            Property(p => p.Desc)
                .IsOptional()
                .HasMaxLength(255)
                .HasColumnName("Desc");
        }

        protected override void ConfigTableName()
        {
            ToTable("Servico");
        }
    }
}
