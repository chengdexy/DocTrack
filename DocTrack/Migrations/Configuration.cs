namespace DocTrack.Migrations
{
    using DocTrack.Common;
    using DocTrack.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DocTrack.DAL.MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DocTrack.DAL.MainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var docList = new List<Document>
            {
                new Document
                {
                    Title="标题",
                    SerialNumber="文号",
                    SecretLevel=SecretLevel.High,
                    Quantity=5,
                    DistributionScope="分发范围",
                    Remark="备注",
                    SubDocuments=new List<SubDocument>
                    {
                        new SubDocument
                        {
                            DocumentID=1,
                            CirculationOperations=new List<CirculationOperation>
                            {
                                new CirculationOperation
                                {
                                    SubDocumentID=1,
                                    HandmanName="chengdexy",
                                    OperationType=OperationType.Send,
                                    TargetName="mr.zhou",
                                    HappenTime=DateTime.Now
                                }
                            }
                        }
                    }
                }
            };
            docList.ForEach(dl => context.Documents.AddOrUpdate(doc => doc.Title, dl));
            context.SaveChanges();
        }
    }
}
