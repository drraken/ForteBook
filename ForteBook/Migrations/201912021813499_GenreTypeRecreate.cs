namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreTypeRecreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "GenreTypeId", c => c.Int(nullable: false));

            CreateTable(
                "dbo.GenreTypes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateIndex("dbo.Books", "GenreTypeId");
            AddForeignKey("dbo.Books", "GenreTypeId", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
