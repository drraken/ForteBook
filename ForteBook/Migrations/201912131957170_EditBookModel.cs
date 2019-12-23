namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "RatingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "RatingId");
          

        }

        public override void Down()
        {
           
            DropIndex("dbo.Books", new[] { "RatingId" });
            DropColumn("dbo.Books", "RatingId");
        }
    }
}
