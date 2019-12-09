namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreateingDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false),
                    LastName = c.String(nullable: false),
                    Role = c.String(nullable: false),
                    IsSubscribedToNewsletter = c.Boolean(nullable: false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Description = c.String(nullable: false)
                })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
        }
    }
}
