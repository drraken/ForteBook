namespace ForteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0e02fdf4-eaa7-408f-993f-8ed0f29a680b', N'chiluta3@gmail.com', 0, N'AK1u0G4JJEYTgmHctox8q/7wwgy7tM42b2GRLuuFbgrXV/h4l6r6geJSyFUNFcQYmg==', N'4d7cb2be-7319-47e6-a33c-6b5e74a13773', NULL, 0, 0, NULL, 1, 0, N'chiluta3@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'23bc4bf4-ca09-4c07-9562-33d6c622cba6', N'admin@fortebook.com', 0, N'AKLbfCbasNUCTPUm4+AxHbNXUoRbnlJFsKwj4xYRemODMLRAbDSzqM0WheQrv/haTw==', N'cc1bcf97-1031-4f36-aecf-6064f2ddb262', NULL, 0, 0, NULL, 1, 0, N'admin@fortebook.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3dbb0b13-3be5-458a-a017-02c42ac27ccb', N'chiluta1@gmail.com', 0, N'AAkz6gdsPdPDGgoD6rlyC5CI1vwmxaJAF5mzKYMOgH+K/ZP8WwcZsOCUwssFpI2CaQ==', N'fe69f90e-a902-46e3-a564-690cecb7457c', NULL, 0, 0, NULL, 1, 0, N'chiluta1@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eeff4bd6-8178-4783-bfed-3f52a8a9e30a', N'guest@fortebook.com', 0, N'ACAFjYcZhF6cYmXqRJZ/K8uUfrMjthR2taGHU21vb1m7Iz3Jx375tfRGekVTqr3kUg==', N'b313670a-0963-4ef2-9f51-3c7adb885b1b', NULL, 0, 0, NULL, 1, 0, N'guest@fortebook.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8363a7ad-cf04-4f88-8515-18a46217fae2', N'CanManageBooks')               

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'23bc4bf4-ca09-4c07-9562-33d6c622cba6', N'8363a7ad-cf04-4f88-8515-18a46217fae2')
");
        }
        
        public override void Down()
        {
        }
    }
}
