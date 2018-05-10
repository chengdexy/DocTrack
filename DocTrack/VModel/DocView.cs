using DocTrack.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.VModel
{
    /// <summary>
    /// document的view model用于在frmSubDocument中展示数据
    /// 每个document对应一组DocView
    /// </summary>
    class DocView
    {
        //对应的子文档id
        public int ID { get; set; }
        //最后一次操作此子文档后,子文档的状态
        public OperationType OperationType { get; set; }
        //最后一次操作此子文档时的经手人
        public string TargetName { get; set; }
        //最后一次操作此子文档时的经手人
        public string HandmanName { get; set; }
        //最后一次操作此子文档的时间
        public DateTime LastOperTime { get; set; }
    }
}
