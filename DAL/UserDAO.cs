using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DBUtility;
using 资产管理系统.Model;

namespace 资产管理系统.DAL
{
    public class UserDAO
    {
        public 资产管理系统.Model.SysUser GetUserByName(string userName)
        {
            string strSql = "select * from SyUsers where loginname=@loginname";
            DBUtility.SQLHelper helper = new SQLHelper();
            SqlParameter p_LoginName = new SqlParameter("@loginname", SqlDbType.VarChar, 50);
            p_LoginName.Value = userName;
            DataTable dt=helper.GetData(strSql, p_LoginName);
            if (dt!=null && dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0]; // 结果只有一行
                资产管理系统.Model.SysUser user=new SysUser();
                user.Id =(int) dr[0];
                user.LoginName = dr[1].ToString();
                user.PassWord = dr[2].ToString();
                user.Name = dr[3].ToString();
                return user;
            }
            else
            {
                return null;
            }          
        }       
    }
}
