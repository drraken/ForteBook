namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBooks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Books (Name, Rating, Description) VALUES ('Makbet' ,5 ,'Desc 1')");
            Sql("INSERT INTO Books (Name, Rating, Description) VALUES ('Antygona',6 ,'Desc 2')");
            Sql("INSERT INTO Books (Name, Rating, Description) VALUES ('Balladyna',2 ,'Desc 3')");
            Sql("INSERT INTO Books (Name, Rating, Description) VALUES ('Wesele',8 ,'Desc 4')");
        }
        
        public override void Down()
        {
        }
    }
}
