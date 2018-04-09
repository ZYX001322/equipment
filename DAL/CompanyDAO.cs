using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DBUtility;
using 资产管理系统.Model;

namespace 资产管理系统.DAL
{
    public class CompanyDAO
    {
        /// <summary>
        /// 获取公司信息
        /// </summary>
        /// <returns></returns>
        public static 资产管理系统.Model.Company GetInfo()
        {
            string sqlStr = "select top 1* from CompanyInfo";
            SQLHelper helper = new SQLHelper();
            DataTable dt = helper.GetData(sqlStr);          
            if (dt != null && dt.Rows.Count > 0)
            {
                Company comp = new Company();
                comp.Id = (int)dt.Rows[0][0]; // 第一行第1列
                comp.Name = dt.Rows[0][1].ToString(); // 第一行第2列
                comp.Master = dt.Rows[0][2].ToString();
                comp.Address = dt.Rows[0][3].ToString();
                return comp;
            }
            else
            {
                return null;
            }
            
        }

        /// <summary>
        /// 修改公司信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="linkman"></param>
        /// <param name="address"></param>
        public static bool UpdateCompany(string name, string linkman, string address)
        {
            string sqlStr = string.Format("update CompanyInfo set name='{0}',linkman='{1}',address='{2}'", name, linkman,address);
            SQLHelper helper = new SQLHelper();
            return helper.ExecuteNonQuery(sqlStr) > 0;
        }

    }
}
