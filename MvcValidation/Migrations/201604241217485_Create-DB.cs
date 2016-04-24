namespace MvcValidation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 254),
                        Password = c.String(nullable: false, maxLength: 16),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "Email" });
            DropTable("dbo.Customers");
        }
    }
}
