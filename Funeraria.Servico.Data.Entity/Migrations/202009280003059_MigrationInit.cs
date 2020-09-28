namespace Funeraria.Servico.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 100),
                        Data = c.Int(nullable: false),
                        Valor = c.Int(nullable: false),
                        Desc = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Servico");
        }
    }
}
