using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 资产名称(资源表)
    /// </summary>
    public class EqName:Resources
    {
        public EqName()
        {          
        }

        public EqName(int id, string name) : base(id, name)
        {            
        }

    }
}
