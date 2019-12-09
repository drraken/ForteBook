namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneMoreMigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Books", new[] { "GenreType_Id" });
            AlterColumn("dbo.Books", "GenreTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
