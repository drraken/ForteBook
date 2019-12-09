namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneMoreMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "GenreType_Id", c => c.Int());
            CreateIndex("dbo.Books", "GenreType_Id");
            AddForeignKey("dbo.Books", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
