using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    /// <summary>
    /// 系统用户实体
    /// </summary>
    public class SysUser
    {
        /// <summary>
        /// 自增长主键
        /// </summary>
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string loginName;

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
