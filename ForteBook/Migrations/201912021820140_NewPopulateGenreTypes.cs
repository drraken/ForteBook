namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Science Fiction')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Drama')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Action and Adventure')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Romance')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Horror')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Science')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
        }
    }
}
