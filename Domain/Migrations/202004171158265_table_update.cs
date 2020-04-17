namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_update : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Employees SET PESEL=123456789, DateOfBirth='1990-05-06T21:37:00.00' where EmployeeID = 1");
            Sql("UPDATE dbo.Employees SET PESEL=333444555, DateOfBirth='1985-03-02T21:37:00.00' where EmployeeID = 2");
            Sql("UPDATE dbo.Employees SET PESEL=999888777, DateOfBirth='1996-08-04T21:37:00.00' where EmployeeID = 3");
        }
        
        public override void Down()
        {
        }
    }
}
