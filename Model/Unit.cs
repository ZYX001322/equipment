using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 资产的计量单位(资源表)
    /// </summary>
    public class Unit:Resources
    {
        public Unit()
        {           
        }

        public Unit(int id, string name) : base(id, name)
        {           
        }
    }
}
