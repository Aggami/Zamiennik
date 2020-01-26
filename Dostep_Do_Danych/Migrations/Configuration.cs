namespace Dostep_Do_Danych.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dostep_Do_Danych.ZamiennikKontekst>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Dostep_Do_Danych.ZamiennikKontekst";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Dostep_Do_Danych.ZamiennikKontekst context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
