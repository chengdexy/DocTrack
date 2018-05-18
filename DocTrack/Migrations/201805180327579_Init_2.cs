namespace DocTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "CheckTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "CheckTime");
        }
    }
}
