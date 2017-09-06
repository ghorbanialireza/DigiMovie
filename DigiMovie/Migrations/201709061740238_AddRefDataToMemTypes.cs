namespace DigiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRefDataToMemTypes : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[MembershipTypes]
            ([Id],[Name],[DurationInMonth],[SignUpFee],[DiscountRate]) VALUES(1, N'رایگان',0,0,0)");
            Sql(@"INSERT INTO [dbo].[MembershipTypes]
            ([Id],[Name],[DurationInMonth],[SignUpFee],[DiscountRate]) VALUES(2, N'ماهانه',1,1000,10)");
            Sql(@"INSERT INTO [dbo].[MembershipTypes]
            ([Id],[Name],[DurationInMonth],[SignUpFee],[DiscountRate]) VALUES(3, N'سه ماهه',3,2000,20)");
            Sql(@"INSERT INTO [dbo].[MembershipTypes]
            ([Id],[Name],[DurationInMonth],[SignUpFee],[DiscountRate]) VALUES(4, N'سالیانه',12,5000,50)");
        }
        
        public override void Down()
        {
        }
    }
}
