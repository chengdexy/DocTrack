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

        //判断数据库中doc表是否为空
        private static bool IsEmpty()
        {
            return Db.Documents.Count() == 0;
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

        //返回指定id的document对象是否存在
        private static bool IsExist(int id)
        {
            return Db.Documents.Find(id) != null;
        }

        //更新指定doc内容
        internal static void UpdateDocument(Document newDoc)
        {
            DeleteDocument(newDoc.ID);
            AddNewDocument(newDoc);
        }

        //删除指定id的doc
        internal static void DeleteDocument(int id)
        {
            var doc = Db.Documents.Find(id);
            Db.Documents.Remove(doc);
            Db.SaveChanges();
        }

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
    }
}
