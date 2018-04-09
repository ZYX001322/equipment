using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using 资产管理系统.Model;

namespace 资产管理系统.DAL
{
    public class DepartmentDAO
    {
        /// <summary>
        /// 获得所有部门的信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllDepartments()
        {
            string sqlStr = "select * from Department";
            return new DBUtility.SQLHelper().GetData(sqlStr);
        }

        /// <summary>
        /// 添加一个部门
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public static bool AddDepartment(Department dept)
        {
            string sqlStr = string.Format("insert into Department values('{0}') ",dept.Name);
            return new DBUtility.SQLHelper().ExecuteNonQuery(sqlStr) > 0;
        }

        /// <summary>
        /// 删除一个部门
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DelDepartment(int id)
        {
            string sqlStr = "delete from Department where id=" + id;
            return (new SQLHelper()).ExecuteNonQuery(sqlStr) > 0;
        }

        /// <summary>
        /// 修改部门信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool UpateDepartment(Department dept)
        {
            string sqlStr = string.Format("update Department set departname='{0}' where id='{1}'",dept.Name,dept.Id);
            return (new SQLHelper()).ExecuteNonQuery(sqlStr) > 0;
        }

    }
}
