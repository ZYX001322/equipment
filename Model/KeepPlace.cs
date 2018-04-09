using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 资产的保管地点(资源表)
    /// </summary>
    public class KeepPlace:Resources
    {
        public KeepPlace()
        {           
        }

        public KeepPlace(int id, string name) : base(id, name)
        {            
        }

    }
}
