using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocTrack.Model;
using DocTrack.VModel;

namespace DocTrack.BLL
{
    //将entity实例转化为需要的view model实例
    static class ViewFactory
    {
        //将一个doc转化为一组docview,用于在frmSubDocument中展示数据
        internal static List<DocView> DocToViews(Document doc)
        {
            List<DocView> docViewList = new List<DocView>();
            doc.SubDocuments.ToList().ForEach(sub =>
            {
                //如果为null将导致sub.LastOperation为null,进而导致异常
                if (sub.CirculationOperations != null)
                {
                    docViewList.Add(new DocView
                    {
                        ID = sub.ID,
                        HandmanName = sub.LastOperation().HandmanName,
                        TargetName = sub.LastOperation().TargetName,
                        OperationType = sub.LastOperation().OperationType,
                        LastOperTime = sub.LastOperation().HappenTime
                    });
                }
            });
            return docViewList;
        }
    }
}
