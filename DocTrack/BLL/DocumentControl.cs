using DocTrack.DAL;
using DocTrack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.BLL
{
    static class DocumentControl
    {
        internal static MainContext Db { get; set; } = new MainContext();

        //返回所有Document, 不含子集
        internal static List<Document> GetDocuments()
        {
            return Db.Documents.ToList();
        }

        //将作为参数的document对象保存入数据库
        //前提: doc的各项属性已经过验证
        internal static void AddNewDocument(Document doc)
        {
            Db.Documents.Add(doc);
            Db.SaveChanges();
        }
    }
}
