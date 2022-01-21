namespace CartorioFacil.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Casamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataCasamento = c.DateTime(nullable: false),
                        DataNascimentoPrimeiroConjuge = c.DateTime(nullable: false),
                        NomeCompletoPrimeiroConjuge = c.String(nullable: false),
                        CpfPrimeiroConjuge = c.String(),
                        NomePaiPrimeiroConjuge = c.String(),
                        NomeMaePrimeiroConjuge = c.String(),
                        DataNascimentoPaiPrimeiroConjuge = c.DateTime(nullable: false),
                        DataNascimentoMaePrimeiroConjuge = c.DateTime(nullable: false),
                        CpfPaiPrimeiroConjuge = c.String(),
                        CpfMaePrimeiroConjuge = c.String(),
                        DataNascimentoSegundoConjuge = c.DateTime(nullable: false),
                        NomeCompletoSegundoConjuge = c.String(nullable: false),
                        CpfSegundoConjuge = c.String(),
                        NomePaiSegundoConjuge = c.String(),
                        NomeMaeSegundoConjuge = c.String(),
                        DataNascimentoPaiSegundoConjuge = c.DateTime(nullable: false),
                        DataNascimentoMaeSegundoConjuge = c.DateTime(nullable: false),
                        CpfPaiSegundoConjuge = c.String(),
                        CpfMaeSegundoConjuge = c.String(),
                        DataRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Nascimento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataNascimento = c.DateTime(nullable: false),
                        NomeDoRegistrado = c.String(nullable: false),
                        NomeDoPai = c.String(),
                        NomeDaMae = c.String(),
                        DataNascimentoDoPai = c.DateTime(nullable: false),
                        DataNascimentoDaMae = c.DateTime(nullable: false),
                        CpfDoPai = c.String(),
                        CpfDaMae = c.String(),
                        DataRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Obito",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataObito = c.DateTime(nullable: false),
                        NomeDoFalecido = c.String(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        NomeDoPai = c.String(),
                        NomeDaMae = c.String(),
                        DataNascimentoDoPai = c.DateTime(nullable: false),
                        DataNascimentoDaMae = c.DateTime(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("public.Obito");
            DropTable("public.Nascimento");
            DropTable("public.Casamento");
        }
    }
}
