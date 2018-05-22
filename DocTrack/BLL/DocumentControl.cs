using DocTrack.DAL;
using DocTrack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DocTrack.BLL
{
    static class DocumentControl
    {
        internal static MainContext Db { get; set; } = new MainContext();

        //返回所有Document, 不含子集
        internal static List<Document> GetDocuments()
        {
            if (!IsEmpty())
            {
                return Db.Documents.ToList();
            }
            return null;
        }
        //重载上一个, 提供筛选(模糊匹配文号/标题)
        internal static List<Document> GetDocuments(string filter)
        {
            if (!IsEmpty())
            {
                List<Document> all = Db.Documents.ToList();
                List<Document> result = new List<Document>();
                all.ForEach(doc =>
                {
                    if (doc.SerialNumber.IndexOf(filter) != -1 || doc.Title.IndexOf(filter) != -1)
                    {
                        //模糊匹配文号或标题
                        result.Add(doc);
                    }
                });
                return result;
            }
            return null;
        }
        //生产环境中, 如果type表无数据则自动添加数据
        internal static void CheckDb()
        {
            if (Db.DocumentTypes.Count() == 0)
            {
                Db.DocumentTypes.Add(
                    new DocumentType
                    {
                        Name = "测试"
                    }
                    );
                Db.SaveChanges();
            }
        }

        //判断数据库中doc表是否为空
        private static bool IsEmpty()
        {
            return Db.Documents.Count() == 0;
        }

        internal static List<DocumentType> GetDocTypeList()
        {
            return Db.DocumentTypes.ToList();
        }


        //根据子文档id,返回其包含的操作列表
        internal static List<CirculationOperation> GetOperBySubID(int id)
        {
            if (id != 0)
            {
                return Db.SubDocuments
                    .Include(sd => sd.CirculationOperations)
                    .FirstOrDefault(sd => sd.ID == id)
                    .CirculationOperations
                    .ToList();
            }
            return null;
        }

        //获取指定id的doc, 并同时包含其子集
        internal static Document GetDocumentWithDetails(int id)
        {
            if (IsExist(id))
            {
                return Db.Documents
                    .Include(doc => doc.SubDocuments.Select(sub => sub.CirculationOperations))
                    .Where(doc => doc.ID == id)
                    .FirstOrDefault();
            }
            return null;
        }

        //将作为参数的document对象保存入数据库
        //前提: doc的各项属性已经过验证
        internal static void AddNewDocument(Document doc)
        {
            Db.Documents.Add(doc);
            Db.SaveChanges();
        }

        //返回指定ID的document对象, 不包含子集
        internal static Document GetDocumentById(int id)
        {
            if (IsExist(id))
            {
                return Db.Documents.Find(id);
            }
            return null;
        }
        //向指定id的subdoc中插入一条操作
        internal static void AddNewOperation(int viewID, CirculationOperation oper)
        {
            var sub = GetSubDocWithDetails(viewID);
            sub.CirculationOperations.Add(oper);
            Db.SaveChanges();
        }

        //返回指定id的document对象是否存在
        private static bool IsExist(int id)
        {
            return Db.Documents.Find(id) != null;
        }

        //更新指定doc内容
        internal static void UpdateDocument(Document newDoc)
        {
            int id = newDoc.ID;
            AddNewDocument(newDoc);
            DeleteDocument(id);
        }

        //删除指定id的doc
        internal static void DeleteDocument(int id)
        {
            var doc = GetDocumentWithDetails(id);
            Db.Documents.Remove(doc);
            Db.SaveChanges();
        }

        //Todo: 此方法未真正使用, 发布时如此todo仍在, 删除此方法
        //根据文号或电报号返回id
        internal static int GetIdBySerialNumber(string serialNum)
        {
            var doc = Db.Documents.FirstOrDefault(d => d.SerialNumber == serialNum);
            if (doc != null)
            {
                return doc.ID;
            }
            return 0;
        }
        //创建一个全新的工作流,用于执行支线流程
        internal static void CreateNewSubDoc(int id)
        {
            Document doc = GetDocumentWithDetails(id);
            doc.SubDocuments.Add(new SubDocument
            {
                CirculationOperations = new List<CirculationOperation>
                {
                    new CirculationOperation
                    {
                        OperationType=Common.OperationType.未开始,
                        HandmanName="系统",
                        TargetName="系统",
                        HappenTime=DateTime.Now
                    }
                }
            });
            Db.Entry(doc).State = EntityState.Modified;
            Db.SaveChanges();
        }
        //依据viewid删除其对应的subdocument数据(其下子集也被删除)
        internal static void DeleteSubDocById(int id)
        {
            var sub = GetSubDocWithDetails(id);
            Db.SubDocuments.Remove(sub);
            Db.SaveChanges();
        }

        private static SubDocument GetSubDocWithDetails(int id)
        {
            if (IsExistSubDoc(id))
            {
                return Db.SubDocuments
                    .Include(sub => sub.CirculationOperations)
                    .Where(sub => sub.ID == id)
                    .FirstOrDefault();
            }
            return null;
        }

        private static bool IsExistSubDoc(int id)
        {
            return Db.SubDocuments.Find(id) != null;
        }
        //依据operID删除指定的操作记录
        internal static void DeleteOperationById(int operID)
        {
            var oper = Db.CirculationOperations.Find(operID);
            if (oper != null)
            {
                Db.Entry(oper).State = EntityState.Deleted;
                Db.SaveChanges();
            }
        }
    }
}
