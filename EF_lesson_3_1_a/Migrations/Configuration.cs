namespace EF_lesson_3_1_a.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_lesson_3_1_a.SoccerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_lesson_3_1_a.SoccerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Players.AddOrUpdate(
              p => p.Name,
              new Player { Name = "Andrew Peters", Position = "вратарь", Age = 23, TeamId = 1, Team = new Team() },
              new Player { Name = "Brice Lambson", Position = "нападающий", Age = 24, TeamId = 1, Team = new Team() },
              new Player { Name = "Rowan Miller", Position = "полузащитник", Age = 25, TeamId = 1, Team = new Team() }
            );
            
        }
    }
}
