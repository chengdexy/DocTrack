namespace DocTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CirculationOperation", "OperationType", c => c.Int(nullable: false));
            AddColumn("dbo.CirculationOperation", "HandmanName", c => c.String());
            AddColumn("dbo.CirculationOperation", "TargetName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CirculationOperation", "TargetName");
            DropColumn("dbo.CirculationOperation", "HandmanName");
            DropColumn("dbo.CirculationOperation", "OperationType");
        }
    }
}
