namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeUnnecesaryyTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Books");
            DropTable("dbo.GenreTypes");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
        
        }
    }
}
