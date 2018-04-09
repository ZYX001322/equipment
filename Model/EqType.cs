using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 资产的类型(资源表)
    /// </summary>
    public class EqType:Resources
    {
        public EqType()
        {            
        }

        public EqType(int id, string name) : base(id, name)
        {            
        }
    }
}
