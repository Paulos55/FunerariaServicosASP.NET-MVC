using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria.Servico.Generic.Entity
{
    public abstract class FunerariaEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public FunerariaEntityAbstractConfig()
        {
            ConfigTableName();
            ConfigTableCamp();
            ConfigPrimaryKey();
            ConfigForeignKey();
        }

        protected abstract void ConfigForeignKey();

        protected abstract void ConfigPrimaryKey();
        
        protected abstract void ConfigTableCamp();

        protected abstract void ConfigTableName();
    }
}
