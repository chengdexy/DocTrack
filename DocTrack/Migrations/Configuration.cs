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

            //var docList = new List<Document>
            //{
            //    new Document
            //    {
            //        Title="标题",
            //        SerialNumber="文号",
            //        SecretLevel=SecretLevel.High,
            //        Quantity=5,
            //        DistributionScope="分发范围",
            //        Remark="备注",
            //        SubDocuments=new List<SubDocument>
            //        {
            //            new SubDocument
            //            {
            //                CirculationOperations=new List<CirculationOperation>
            //                {
            //                    new CirculationOperation
            //                    {
            //                        HandmanName="xy1",
            //                        OperationType=OperationType.Send,
            //                        TargetName="mr.1",
            //                        HappenTime=DateTime.Now
            //                    }
            //                }
            //            },
            //            new SubDocument
            //            {
            //                CirculationOperations=new List<CirculationOperation>
            //                {
            //                    new CirculationOperation
            //                    {
            //                        HandmanName="xy3",
            //                        OperationType=OperationType.Send,
            //                        TargetName="mr.3",
            //                        HappenTime=DateTime.Now
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    new Document
            //    {
            //        Title="标题2",
            //        SerialNumber="文号2",
            //        SecretLevel=SecretLevel.High,
            //        Quantity=5,
            //        DistributionScope="分发范围2",
            //        Remark="备注2",
            //        SubDocuments=new List<SubDocument>
            //        {
            //            new SubDocument
            //            {
            //                CirculationOperations=new List<CirculationOperation>
            //                {
            //                    new CirculationOperation
            //                    {
            //                        HandmanName="chengdexy2",
            //                        OperationType=OperationType.Send,
            //                        TargetName="mr.zhou2",
            //                        HappenTime=DateTime.Now
            //                    }
            //                }
            //            },
            //            new SubDocument
            //            {
            //                CirculationOperations=new List<CirculationOperation>
            //                {
            //                    new CirculationOperation
            //                    {
            //                        HandmanName="xy4",
            //                        OperationType=OperationType.Send,
            //                        TargetName="mr.4",
            //                        HappenTime=DateTime.Now
            //                    }
            //                }
            //            }
            //        }
            //    }
            //};
            //docList.ForEach(dl => context.Documents.AddOrUpdate(doc => doc.Title, dl));
            //context.SaveChanges();
            var typeList = new List<DocumentType>
            {
                new DocumentType
                {
                    Name="中办发"
                },
                new DocumentType
                {
                    Name="市办发"
                }
            };
            typeList.ForEach(tl => context.DocumentTypes.AddOrUpdate(dt => dt.Name, tl));
            context.SaveChanges();
        }
    }
}
