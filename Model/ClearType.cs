using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 资产的清理方式(资源表)
    /// </summary>
    public class ClearType:Resources
    {
        public ClearType()
        {           
        }

        public ClearType(int id, string name) : base(id, name)
        {            
        }
    }
}
