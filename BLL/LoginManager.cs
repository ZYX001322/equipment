using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 资产管理系统.Model;
using 资产管理系统.DAL;

namespace 资产管理系统.BLL
{
    public class LoginManager
    {
        /// <summary>
        /// 登陆方法
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <param name="user">登录成功后，获取的用户实体；若登陆失败，用户实体为空</param>
        /// <returns></returns>
        public static bool Login(string userName, string passWord, out SysUser user)
        {
            资产管理系统.DAL.UserDAO uDao = new UserDAO();
            资产管理系统.Model.SysUser sysuser = uDao.GetUserByName(userName);
            if (sysuser != null) // 存在该用户
            {
                if (sysuser.PassWord == passWord) // 输入密码与该用户密码相同
                {
                    user = sysuser;
                    return true;
                }
                else // 输入密码不正确
                {
                    user = null;
                    return false;
                }
            }
            else // 没有该用户
            {
                user = null;
                return false;
            }
        }
    }
}
