namespace DocTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CirculationOperation", "Remark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CirculationOperation", "Remark");
        }
    }
}
