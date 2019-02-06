namespace ERPComercial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gustavo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientePJs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Uf = c.String(),
                        Telefone = c.String(),
                        Situacao = c.String(),
                        Bairro = c.String(),
                        Logradouro = c.String(),
                        Numero = c.String(),
                        CEP = c.String(),
                        Municipio = c.String(),
                        Porte = c.String(),
                        Abertura = c.String(),
                        natureza_juridica = c.String(),
                        CNPJ = c.String(),
                        Ultima_Atualizacao = c.String(),
                        status = c.String(),
                        Tipo = c.String(),
                        Fantasia = c.String(),
                        Complemento = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientePJs");
        }
    }
}
