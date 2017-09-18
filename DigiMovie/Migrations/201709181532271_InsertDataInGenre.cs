namespace DigiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataInGenre : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[Genres]
            ([Id],[Name]) VALUES(1, N'کمدی')");
            Sql(@"INSERT INTO [dbo].[Genres]
            ([Id],[Name]) VALUES(2, N'ترسناک')");
            Sql(@"INSERT INTO [dbo].[Genres]
            ([Id],[Name]) VALUES(3, N'عاشقانه')");
            Sql(@"INSERT INTO [dbo].[Genres]
            ([Id],[Name]) VALUES(4, N'اکشن')");
            Sql(@"INSERT INTO [dbo].[Genres]
            ([Id],[Name]) VALUES(5, N'اجتماعی')");
        }

        public override void Down()
        {
        }
    }
}
