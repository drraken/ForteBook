namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingRatings : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ratings(Value, ApplicationUserId, BookId) VALUES('3', 'chiluta3@gmail.com', '4')");
            Sql("INSERT INTO Ratings(Value, ApplicationUserId, BookId) VALUES('4', 'chiluta3@gmail.com', '4')");
            Sql("INSERT INTO Ratings(Value, ApplicationUserId, BookId) VALUES('2', 'chiluta3@gmail.com', '4')");
            Sql("INSERT INTO Ratings(Value, ApplicationUserId, BookId) VALUES('5', 'chiluta3@gmail.com', '4')");

        }

        public override void Down()
        {
        }
    }
}
