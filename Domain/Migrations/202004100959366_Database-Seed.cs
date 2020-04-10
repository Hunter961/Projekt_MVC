namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseSeed : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees (FirstName, LastName, City, Country, Salary) VALUES ('Zbigniew','Nowak', 'Kraków', 'Polska', 2800)");
            Sql("INSERT INTO Employees (FirstName, LastName, City, Country, Salary) VALUES ('Tomasz','Kowalski', 'Warszawa', 'Polska', 3500)");
            Sql("INSERT INTO Employees (FirstName, LastName, City, Country, Salary) VALUES ('Józef','Głowa', 'Gdańsk', 'Polska', 4000)");
        }
        
        public override void Down()
        {
        }
    }
}
