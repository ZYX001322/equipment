using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 系统资源表基类
    /// </summary>
    public class Resources
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 空的无参构造函数
        /// </summary>
        public Resources()
        {
        }

        /// <summary>
        /// 空的有参构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Resources(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// 重写Resources的ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.name;
        }
    }
}
