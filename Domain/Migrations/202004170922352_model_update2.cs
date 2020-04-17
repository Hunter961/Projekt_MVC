namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model_update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PESEL", c => c.String(maxLength: 9));
            AddColumn("dbo.Employees", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DateOfBirth");
            DropColumn("dbo.Employees", "PESEL");
        }
    }
}
