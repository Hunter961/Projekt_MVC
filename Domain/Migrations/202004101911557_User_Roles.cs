namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_Roles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES (1, 'Admin')");
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES (2, 'User')");
        }
        
        public override void Down()
        {
        }
    }
}
