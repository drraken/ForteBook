namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users (FirstName, LastName, Role) VALUES ('Maciej' ,'Musiał' ,'Customer')");
            Sql("INSERT INTO Users (FirstName, LastName, Role) VALUES ('Iwo','Zawadzki' ,'Customer')");
            Sql("INSERT INTO Users (FirstName, LastName, Role) VALUES ('Aleksandra','Olszewska' ,'Customer')");
            Sql("INSERT INTO Users (FirstName, LastName, Role) VALUES ('Zofia','Olejnik','Customer')");
        }
        
        public override void Down()
        {
        }
    }
}
