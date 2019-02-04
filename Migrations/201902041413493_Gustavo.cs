namespace ERPComercial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gustavo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientePFs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Profissao = c.String(),
                        Email = c.String(),
                        CPF = c.String(),
                        CEP = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Bairro = c.String(),
                        logradouro = c.String(),
                        TipoLogradouro = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientePFs");
        }
    }
}
