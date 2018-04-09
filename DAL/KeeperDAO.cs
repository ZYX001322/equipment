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
    public class KeeperDAO
    {
        /// <summary>
        /// 获得所有仓库保管员的信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllKeepers()
        {
            string sqlStr = "select * from Keeper";
            return new DBUtility.SQLHelper().GetData(sqlStr);
        }

        /// <summary>
        /// 添加一个仓库保管人员
        /// </summary>
        /// <param name="keeper"></param>
        /// <returns></returns>
        public static bool AddKeeper(Keeper keeper)
        {
            string sqlStr = string.Format("insert into Keeper values('{0}') ", keeper.Name);
            return new DBUtility.SQLHelper().ExecuteNonQuery(sqlStr) > 0;
        }

        /// <summary>
        /// 删除一个仓管人员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DelKeeper(int id)
        {
            string sqlStr = "delete from keeper where id=" + id;
            return (new SQLHelper()).ExecuteNonQuery(sqlStr) > 0;
        }

    }
}
