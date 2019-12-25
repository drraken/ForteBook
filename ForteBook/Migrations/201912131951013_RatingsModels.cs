namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingsModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        ApplicationUserId = c.String(maxLength: 128),
                        BookId = c.Int(nullable: false)
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ApplicationUserId);

        }
        
        public override void Down()
        {
            DropIndex("dbo.Ratings", new[] { "ApplicationUserId" });
            DropTable("dbo.Ratings");
        }
    }
}
