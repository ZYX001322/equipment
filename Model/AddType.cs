using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 资产增长方式（资源表)
    /// </summary>
    public class AddType:Resources
    {
        public AddType()
        {            
        }

        public AddType(int id, string name) : base(id, name)
        {
        }
    }
}
