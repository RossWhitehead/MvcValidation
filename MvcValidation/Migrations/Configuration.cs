namespace MvcValidation.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcValidation.Models.MvcValidationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcValidation.Models.MvcValidationDbContext context)
        {
          context.Customers.AddOrUpdate(
                c => c.Email,
                new Customer { FirstName = "Ross", LastName = "Whitehead", Email = "ross.whitehead@notarealdomain.com", DateOfBirth = new DateTime(1990, 1, 1), Password = "password" },
                new Customer { FirstName = "John", LastName = "Smith", Email = "john.smith@notarealdomain.com", DateOfBirth = new DateTime(1986, 12, 11), Password = "password" }
                );
        }
    }
}
