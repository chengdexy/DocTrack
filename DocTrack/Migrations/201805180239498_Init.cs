namespace DocTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CirculationOperation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubDocumentID = c.Int(nullable: false),
                        OperationType = c.Int(nullable: false),
                        HandmanName = c.String(),
                        TargetName = c.String(),
                        HappenTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SubDocument", t => t.SubDocumentID, cascadeDelete: true)
                .Index(t => t.SubDocumentID);
            
            CreateTable(
                "dbo.SubDocument",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DocumentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Document", t => t.DocumentID, cascadeDelete: true)
                .Index(t => t.DocumentID);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SerialNumber = c.String(),
                        SecretLevel = c.Int(nullable: false),
                        DocumentTypeID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DistributionScope = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocumentType", t => t.DocumentTypeID, cascadeDelete: true)
                .Index(t => t.DocumentTypeID);
            
            CreateTable(
                "dbo.DocumentType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubDocument", "DocumentID", "dbo.Document");
            DropForeignKey("dbo.Document", "DocumentTypeID", "dbo.DocumentType");
            DropForeignKey("dbo.CirculationOperation", "SubDocumentID", "dbo.SubDocument");
            DropIndex("dbo.Document", new[] { "DocumentTypeID" });
            DropIndex("dbo.SubDocument", new[] { "DocumentID" });
            DropIndex("dbo.CirculationOperation", new[] { "SubDocumentID" });
            DropTable("dbo.DocumentType");
            DropTable("dbo.Document");
            DropTable("dbo.SubDocument");
            DropTable("dbo.CirculationOperation");
        }
    }
}
