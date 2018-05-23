namespace DocTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "ISN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "ISN");
        }
    }
}
