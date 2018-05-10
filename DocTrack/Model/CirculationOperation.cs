using DocTrack.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.Model
{
    class CirculationOperation
    {
        public int ID { get; set; }

        //relationship
        public virtual int SubDocumentID { get; set; }
        public virtual SubDocument SubDocument { get; set; }

        //操作类型:0-传出 1-收回
        public OperationType OperationType { get; set; }
        //经手人:传出-取文者 收回-收回者(机要人员)
        public string HandmanName { get; set; }
        //目标人:传出-送阅领导 收回-由谁处取回
        public string TargetName { get; set; }
        //发生时间
        public DateTime HappenTime { get; set; }
    }
}
