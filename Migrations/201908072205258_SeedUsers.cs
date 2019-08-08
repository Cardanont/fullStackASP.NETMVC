namespace FullStackMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38b60674-598d-4947-afbd-c342176c1772', N'admin@fullstack.com', 0, N'AGE5MK/tM2HVVkLNh9GiIiViteNzW/p5MQF7EK6yVaf91VOo3wqu0BogVzOZe60uBQ==', N'bb7dd6b0-5595-4249-a0da-90837d048ee0', NULL, 0, 0, NULL, 1, 0, N'admin@fullstack.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e32dd08-932a-4b65-988b-0160fd05e623', N'guest@fullstack.com', 0, N'AJ9chDDMzn8UAp/UlvD2p5fGk9NciyTOB9qdwDbKfOgsl25hMOEbirvJfBRNM6RROg==', N'48eb67b5-4809-474a-8e2e-d9be448f342a', NULL, 0, 0, NULL, 1, 0, N'guest@fullstack.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'078ba176-8a0e-4c65-b0ca-b9f85c00be6d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'38b60674-598d-4947-afbd-c342176c1772', N'078ba176-8a0e-4c65-b0ca-b9f85c00be6d')

");
        }
        
        public override void Down()
        {
        }
    }
}
