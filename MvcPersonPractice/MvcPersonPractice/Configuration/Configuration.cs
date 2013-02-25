using System.Data.Entity.Migrations;
using MvcPersonPractice.Models;

namespace MvcPersonPractice.Configuration
{
    public class Configuration : DbMigrationsConfiguration<MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}