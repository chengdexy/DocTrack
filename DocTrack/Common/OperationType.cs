using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.Common
{
    enum OperationType
    {
        [Description("传出")]
        Send=0,     //传出
        [Description("收回")]
        Receive=1,   //收回
        [Description("归档")]
        Over=2,  //归档
        [Description("新增")]//此项应只由软件自身使用
        New =999  //新增
    }
}
