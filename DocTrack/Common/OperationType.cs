using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.Common
{
    enum OperationType
    {
        Send=0,     //传出
        Receive=1,   //收回
        Over=2,  //归档
        New=999  //新增,此项应只由软件自身使用
    }
}
