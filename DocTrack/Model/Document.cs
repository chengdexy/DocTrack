using DocTrack.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.Model
{
    /// <summary>
    /// 文档类: 公文/电报等
    /// 文档---子文档---流程操作
    /// </summary>
    class Document
    {
        public int ID { get; set; }
        //文档标题
        public string Title { get; set; }
        //文档编号: 公文--文号, 电报--电报号
        public string SerialNumber { get; set; }
        //密级: 0-无密级 1-秘密 2-机密 3-绝密
        public SecretLevel SecretLevel { get; set; }
        //来文份数
        public int Quantity { get; set; }
        //分发范围
        public string DistributionScope { get; set; }
        //备注
        public string Remark { get; set; }

        //relationship
        public virtual ICollection<SubDocument> SubDocuments { get; set; }
    }
}
