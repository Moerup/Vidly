using Vidly.Models;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //context.Customers.AddOrUpdate(
            //    c => c.Id,
            //    new Customer { Id = 1, Name = "John Smith", IsSubscribedToNewsletter = false, MembershipTypeId = 1, Birthday = DateTime.Parse("12/04/1980")},
            //    new Customer { Id = 2, Name = "Mary Williams", IsSubscribedToNewsletter = true, MembershipTypeId = 2}
            //    );
        }
    }
}
