namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "GenreTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Books", "GenreType_Id", c => c.Int());
            CreateIndex("dbo.Books", "GenreType_Id");
            AddForeignKey("dbo.Books", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Books", new[] { "GenreType_Id" });
            DropColumn("dbo.Books", "GenreType_Id");
            DropColumn("dbo.Books", "GenreTypeId");
            DropTable("dbo.GenreTypes");
        }
    }
}
