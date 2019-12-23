namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ratings", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Books", "RatingId", "dbo.Ratings");
            DropIndex("dbo.Books", new[] { "RatingId" });
            DropIndex("dbo.Ratings", new[] { "ApplicationUserId" });
            AddColumn("dbo.Ratings", "BookId", c => c.Int(nullable: false));
            AlterColumn("dbo.Ratings", "ApplicationUserId", c => c.String());
            DropColumn("dbo.Books", "RatingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "RatingId", c => c.Int(nullable: false));
            AlterColumn("dbo.Ratings", "ApplicationUserId", c => c.String(maxLength: 128));
            DropColumn("dbo.Ratings", "BookId");
            CreateIndex("dbo.Ratings", "ApplicationUserId");
            CreateIndex("dbo.Books", "RatingId");
            AddForeignKey("dbo.Books", "RatingId", "dbo.Ratings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ratings", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
    }
}
