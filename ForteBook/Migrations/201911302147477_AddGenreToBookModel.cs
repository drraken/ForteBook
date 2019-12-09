namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreToBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Books", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Rating", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Description", c => c.String());
            DropColumn("dbo.Books", "Genre");
        }
    }
}
