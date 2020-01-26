namespace Dostep_Do_Danych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Efekt_ksztalcenia",
                c => new
                    {
                        Symbol_efektu_ksztalcenia = c.String(nullable: false, maxLength: 128),
                        Nazwa = c.String(),
                        Typ = c.Int(nullable: false),
                        Plan_studiow_Plan_studiow_id = c.Int(),
                    })
                .PrimaryKey(t => t.Symbol_efektu_ksztalcenia)
                .ForeignKey("dbo.Plan_studiow", t => t.Plan_studiow_Plan_studiow_id)
                .Index(t => t.Plan_studiow_Plan_studiow_id);
            
            CreateTable(
                "dbo.Plan_studiow",
                c => new
                    {
                        Plan_studiow_id = c.Int(nullable: false, identity: true),
                        Poziom_ksztalcenia = c.Int(nullable: false),
                        Czy_studia_stacjonarne = c.Boolean(nullable: false),
                        Czas_trwania = c.Int(nullable: false),
                        Kierunek_Kierunek_id = c.Int(),
                    })
                .PrimaryKey(t => t.Plan_studiow_id)
                .ForeignKey("dbo.Kierunek_studiow", t => t.Kierunek_Kierunek_id)
                .Index(t => t.Kierunek_Kierunek_id);
            
            CreateTable(
                "dbo.Kierunek_studiow",
                c => new
                    {
                        Kierunek_id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Wydzial_Numer_wydzialu = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.Kierunek_id)
                .ForeignKey("dbo.Wydzials", t => t.Wydzial_Numer_wydzialu)
                .Index(t => t.Wydzial_Numer_wydzialu);
            
            CreateTable(
                "dbo.Wydzials",
                c => new
                    {
                        Numer_wydzialu = c.String(nullable: false, maxLength: 3),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Numer_wydzialu);
            
            CreateTable(
                "dbo.Rok_akademicki",
                c => new
                    {
                        Rok_akademicki_id = c.Int(nullable: false, identity: true),
                        Data_rozpoczecia = c.DateTime(nullable: false),
                        Data_zakonczenia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Rok_akademicki_id);
            
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        Kod_kursu = c.String(nullable: false, maxLength: 128),
                        Nazwa_kursu = c.String(nullable: false),
                        Punkty_ECTS = c.Int(nullable: false),
                        Forma_kursu = c.Int(nullable: false),
                        ZZU = c.Int(nullable: false),
                        Czy_egzamin = c.Boolean(nullable: false),
                        Czy_aktywny = c.Boolean(nullable: false),
                        Karta_przedmiotu = c.Binary(),
                        Typ_semestru = c.Int(nullable: false),
                        Semestr = c.Int(nullable: false),
                        Grupa_kursow_id = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Plan_studiow_Plan_studiow_id = c.Int(),
                        Grupa_kursow_Kod_kursu = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Kod_kursu)
                .ForeignKey("dbo.Plan_studiow", t => t.Plan_studiow_Plan_studiow_id)
                .ForeignKey("dbo.Kurs", t => t.Grupa_kursow_Kod_kursu)
                .Index(t => t.Plan_studiow_Plan_studiow_id)
                .Index(t => t.Grupa_kursow_Kod_kursu);
            
            CreateTable(
                "dbo.Zamiennik_kursu",
                c => new
                    {
                        Id_zamiennika = c.Int(nullable: false, identity: true),
                        Kurs_zastepowany_Kod_kursu = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id_zamiennika)
                .ForeignKey("dbo.Kurs", t => t.Kurs_zastepowany_Kod_kursu)
                .Index(t => t.Kurs_zastepowany_Kod_kursu);
            
            CreateTable(
                "dbo.Propozycja_zamiennika",
                c => new
                    {
                        Propozycja_zamiennika_id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Komentarz_Opiniodawcy = c.String(),
                        Kurs_zastepowany_Kod_kursu = c.String(maxLength: 128),
                        Kurs_zastepujacy_Kod_kursu = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Propozycja_zamiennika_id)
                .ForeignKey("dbo.Kurs", t => t.Kurs_zastepowany_Kod_kursu)
                .ForeignKey("dbo.Kurs", t => t.Kurs_zastepujacy_Kod_kursu)
                .Index(t => t.Kurs_zastepowany_Kod_kursu)
                .Index(t => t.Kurs_zastepujacy_Kod_kursu);
            
            CreateTable(
                "dbo.LataPlanowStudiow",
                c => new
                    {
                        IdPlanu = c.Int(nullable: false),
                        IdRoku = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdPlanu, t.IdRoku })
                .ForeignKey("dbo.Plan_studiow", t => t.IdPlanu, cascadeDelete: true)
                .ForeignKey("dbo.Rok_akademicki", t => t.IdRoku, cascadeDelete: true)
                .Index(t => t.IdPlanu)
                .Index(t => t.IdRoku);
            
            CreateTable(
                "dbo.EfektyKsztalceniaKursow",
                c => new
                    {
                        KodKursu = c.String(nullable: false, maxLength: 128),
                        SymbolEfektu = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.KodKursu, t.SymbolEfektu })
                .ForeignKey("dbo.Kurs", t => t.KodKursu, cascadeDelete: true)
                .ForeignKey("dbo.Efekt_ksztalcenia", t => t.SymbolEfektu, cascadeDelete: true)
                .Index(t => t.KodKursu)
                .Index(t => t.SymbolEfektu);
            
            CreateTable(
                "dbo.KursySkladoweZamiennika",
                c => new
                    {
                        IdZamiennika = c.Int(nullable: false),
                        KodKursuSkladowego = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.IdZamiennika, t.KodKursuSkladowego })
                .ForeignKey("dbo.Zamiennik_kursu", t => t.IdZamiennika, cascadeDelete: true)
                .ForeignKey("dbo.Kurs", t => t.KodKursuSkladowego, cascadeDelete: true)
                .Index(t => t.IdZamiennika)
                .Index(t => t.KodKursuSkladowego);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Propozycja_zamiennika", "Kurs_zastepujacy_Kod_kursu", "dbo.Kurs");
            DropForeignKey("dbo.Propozycja_zamiennika", "Kurs_zastepowany_Kod_kursu", "dbo.Kurs");
            DropForeignKey("dbo.Kurs", "Grupa_kursow_Kod_kursu", "dbo.Kurs");
            DropForeignKey("dbo.KursySkladoweZamiennika", "KodKursuSkladowego", "dbo.Kurs");
            DropForeignKey("dbo.KursySkladoweZamiennika", "IdZamiennika", "dbo.Zamiennik_kursu");
            DropForeignKey("dbo.Zamiennik_kursu", "Kurs_zastepowany_Kod_kursu", "dbo.Kurs");
            DropForeignKey("dbo.Kurs", "Plan_studiow_Plan_studiow_id", "dbo.Plan_studiow");
            DropForeignKey("dbo.EfektyKsztalceniaKursow", "SymbolEfektu", "dbo.Efekt_ksztalcenia");
            DropForeignKey("dbo.EfektyKsztalceniaKursow", "KodKursu", "dbo.Kurs");
            DropForeignKey("dbo.Efekt_ksztalcenia", "Plan_studiow_Plan_studiow_id", "dbo.Plan_studiow");
            DropForeignKey("dbo.LataPlanowStudiow", "IdRoku", "dbo.Rok_akademicki");
            DropForeignKey("dbo.LataPlanowStudiow", "IdPlanu", "dbo.Plan_studiow");
            DropForeignKey("dbo.Plan_studiow", "Kierunek_Kierunek_id", "dbo.Kierunek_studiow");
            DropForeignKey("dbo.Kierunek_studiow", "Wydzial_Numer_wydzialu", "dbo.Wydzials");
            DropIndex("dbo.KursySkladoweZamiennika", new[] { "KodKursuSkladowego" });
            DropIndex("dbo.KursySkladoweZamiennika", new[] { "IdZamiennika" });
            DropIndex("dbo.EfektyKsztalceniaKursow", new[] { "SymbolEfektu" });
            DropIndex("dbo.EfektyKsztalceniaKursow", new[] { "KodKursu" });
            DropIndex("dbo.LataPlanowStudiow", new[] { "IdRoku" });
            DropIndex("dbo.LataPlanowStudiow", new[] { "IdPlanu" });
            DropIndex("dbo.Propozycja_zamiennika", new[] { "Kurs_zastepujacy_Kod_kursu" });
            DropIndex("dbo.Propozycja_zamiennika", new[] { "Kurs_zastepowany_Kod_kursu" });
            DropIndex("dbo.Zamiennik_kursu", new[] { "Kurs_zastepowany_Kod_kursu" });
            DropIndex("dbo.Kurs", new[] { "Grupa_kursow_Kod_kursu" });
            DropIndex("dbo.Kurs", new[] { "Plan_studiow_Plan_studiow_id" });
            DropIndex("dbo.Kierunek_studiow", new[] { "Wydzial_Numer_wydzialu" });
            DropIndex("dbo.Plan_studiow", new[] { "Kierunek_Kierunek_id" });
            DropIndex("dbo.Efekt_ksztalcenia", new[] { "Plan_studiow_Plan_studiow_id" });
            DropTable("dbo.KursySkladoweZamiennika");
            DropTable("dbo.EfektyKsztalceniaKursow");
            DropTable("dbo.LataPlanowStudiow");
            DropTable("dbo.Propozycja_zamiennika");
            DropTable("dbo.Zamiennik_kursu");
            DropTable("dbo.Kurs");
            DropTable("dbo.Rok_akademicki");
            DropTable("dbo.Wydzials");
            DropTable("dbo.Kierunek_studiow");
            DropTable("dbo.Plan_studiow");
            DropTable("dbo.Efekt_ksztalcenia");
        }
    }
}
