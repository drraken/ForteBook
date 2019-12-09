namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finallCleanup : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "GenreType_Id");
        }
        
        public override void Down()
        {
        }
    }
}
