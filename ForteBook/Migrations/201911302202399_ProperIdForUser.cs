namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProperIdForUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
        }
    }
}
