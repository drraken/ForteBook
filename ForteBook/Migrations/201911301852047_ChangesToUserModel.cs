namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToUserModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsSubscribedToNewsletter");
        }
    }
}
