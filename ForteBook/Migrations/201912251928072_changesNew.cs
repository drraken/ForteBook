namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesNew : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ratings", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Ratings", "ApplicationUserId");
            CreateIndex("dbo.Ratings", "BookId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Ratings", new[] { "BookId" });
            DropIndex("dbo.Ratings", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Ratings", "ApplicationUserId", c => c.String());
        }
    }
}
