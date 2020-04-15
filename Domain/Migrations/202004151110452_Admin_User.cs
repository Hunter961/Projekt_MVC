namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin_User : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe2a8cf7-8ba6-4490-b60b-a1624f6c9c9b', N'admin@admin.com', 0, N'AGX9Be5WRmYI7OTP5U2XmdLJ4C3+DzVLEV3kvKY0sH+fn5/LFGKrB3cZ7PjEdOgtmw==', N'd06c961d-6c19-4dcd-976e-c12987952aa5', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')");
        }
        
        public override void Down()
        {
        }
    }
}
