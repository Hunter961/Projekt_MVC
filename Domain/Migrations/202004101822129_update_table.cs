namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_table : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Employees SET FirstName = 'Mieczysław' where EmployeeID = 3");
            
        }
        
        public override void Down()
        {
        }
    }
}
