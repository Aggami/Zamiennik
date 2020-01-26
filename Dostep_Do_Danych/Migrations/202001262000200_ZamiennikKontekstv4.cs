namespace Dostep_Do_Danych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZamiennikKontekstv4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", "dbo.Efekt_ksztalcenia");
            DropIndex("dbo.EfektyKsztalceniaKursow", new[] { "SymbolEfektu" });
            DropPrimaryKey("dbo.Efekt_ksztalcenia");
            DropPrimaryKey("dbo.EfektyKsztalceniaKursow");
            AddColumn("dbo.Efekt_ksztalcenia", "EfektKsztalceniaId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Efekt_ksztalcenia", "Symbol_efektu_ksztalcenia", c => c.String());
            AlterColumn("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Efekt_ksztalcenia", "EfektKsztalceniaId");
            AddPrimaryKey("dbo.EfektyKsztalceniaKursow", new[] { "KodKursu", "SymbolEfektu" });
            CreateIndex("dbo.EfektyKsztalceniaKursow", "SymbolEfektu");
            AddForeignKey("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", "dbo.Efekt_ksztalcenia", "EfektKsztalceniaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", "dbo.Efekt_ksztalcenia");
            DropIndex("dbo.EfektyKsztalceniaKursow", new[] { "SymbolEfektu" });
            DropPrimaryKey("dbo.EfektyKsztalceniaKursow");
            DropPrimaryKey("dbo.Efekt_ksztalcenia");
            AlterColumn("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Efekt_ksztalcenia", "Symbol_efektu_ksztalcenia", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Efekt_ksztalcenia", "EfektKsztalceniaId");
            AddPrimaryKey("dbo.EfektyKsztalceniaKursow", new[] { "KodKursu", "SymbolEfektu" });
            AddPrimaryKey("dbo.Efekt_ksztalcenia", "Symbol_efektu_ksztalcenia");
            CreateIndex("dbo.EfektyKsztalceniaKursow", "SymbolEfektu");
            AddForeignKey("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", "dbo.Efekt_ksztalcenia", "Symbol_efektu_ksztalcenia", cascadeDelete: true);
        }
    }
}
