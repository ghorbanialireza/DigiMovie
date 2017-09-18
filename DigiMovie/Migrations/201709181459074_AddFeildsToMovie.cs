namespace DigiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFeildsToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateRelseased", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateRelseased");
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
