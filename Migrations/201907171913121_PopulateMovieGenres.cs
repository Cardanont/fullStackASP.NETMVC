namespace FullStackMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(1, 'Comedy')");
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(2, 'Action')");
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(3, 'Romance')");
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(4, 'Science Fiction')");
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(5, 'Historical')");
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(6, 'Documentary')");
            Sql("INSERT INTO MovieGenres(Id, Name) VALUES(7, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
