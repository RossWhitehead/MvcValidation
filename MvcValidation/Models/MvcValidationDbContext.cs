using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcValidation.Models
{
    public class MvcValidationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}