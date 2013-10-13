namespace Top10AppServices.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Top10AppServices.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Top10AppServices.DataLayer.Top10AppDbContext>
    {                
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }        
    }
}