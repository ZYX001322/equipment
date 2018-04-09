using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtility;
using 资产管理系统.Model;
using System.Data;
using System.Data.SqlClient;

namespace 资产管理系统.DAL
{
    public class EmployeeDAO
    {
        /// <summary>
        ///  添加新员工
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static bool AddEmployee(Employee emp)
        {
            int id = emp.EmpId;
            string name = emp.Name;
            string sex = emp.Sex;
            int deptid = emp.Departid;
            string sqlStr = string.Format("insert into Employee values('{0}','{1}',{2})", name, sex, deptid);
            SQLHelper helper = new SQLHelper();
            return helper.ExecuteNonQuery(sqlStr) > 0;
        }

        /// <summary>
        /// 根据部门号查询员工信息
        /// </summary>
        /// <param name="deptid"></param>
        /// <returns></returns>
        public static DataTable GetAllEmpByDeptID(int deptid)
        {
            SQLHelper helper = new SQLHelper();
            string strSql =
                string.Format(
                    "select a.empid as 工号, a.name as 姓名,a.sex as 性别,b.departname 所在部门 from employee a , department b where a.departid=b.id and a.departid='{0}'",
                    deptid);
            DataTable dt = helper.GetData(strSql);
            return dt;
        }

        /// <summary>
        /// 查询所有员工信息
        /// </summary>
        public static DataTable GetAllEmployees()
        {
            SQLHelper helper = new SQLHelper();
            string strSql =
                string.Format(
                    "select a.empid as 工号, a.name as 姓名,a.sex as 性别,b.departname 所在部门 from employee a , department b where a.departid=b.id");
            DataTable dt = helper.GetData(strSql);
            return dt;
        }

        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static bool UpdateEmployee(Employee emp)
        {
            int id = emp.EmpId;
            string name = emp.Name;
            string sex = emp.Sex;
            int deptid = emp.Departid;
            SQLHelper helper = new SQLHelper();
            string strSql = string.Format("update employee set name='{0}',sex='{1}',departid={2} where empid={3}", 
                                          name, sex, deptid,id);
            return helper.ExecuteNonQuery(strSql) > 0;
        }

        /// <summary>
        /// 删除指定的员工
        /// </summary>
        /// <param name="empId">员工编号</param>
        /// <returns>
        /// -1:代表该员工是仓库保管员，必须取消其仓管身份之后才请允许删除
        /// -2:代表该员工领取的固定资产尚未归还，必须归还之后才允许删除
        /// 0:代表删除失败
        /// 1:代表删除成功
        /// </returns>
        public static int DelEmployee(int empId)
        {
            SQLHelper helper = new SQLHelper();
            string sqlcheckKeeper = string.Format("select count(*) from keeper where id ={0}", empId);
            // 判定工号empId是否为仓库保管员
            //if (int.Parse(helper.ExecuteScalar(sqlcheckKeeper).ToString()) == 0)
            if (helper.ExecuteScalar(sqlcheckKeeper) == 0)
            {
                string sqlcheck = string.Format("select count(*)from Borrow where Borrwer={0}", empId);
                // 判定工号empId是否有资产未还
                if (int.Parse(helper.ExecuteScalar(sqlcheck).ToString()) == 0)
                {
                    string sqlDel = string.Format("delete from employee where empid={0}", empId);
                    return helper.ExecuteNonQuery(sqlDel);
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// 得到某一个员工的信息,返回Employee对象
        /// </summary>
        /// <param name="empid"></param>
        /// <returns></returns>
        public static Employee GetEmployeeById(int empid)
        {
            string sql = string.Format("select * from employee where empid={0}", empid);
            SQLHelper sh = new SQLHelper();
            DataTable dt = sh.GetData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                Employee employee = new Employee();
                employee.EmpId = empid;
                employee.Name = dt.Rows[0][1].ToString();
                employee.Sex = dt.Rows[0][2].ToString();
                employee.Departid = int.Parse(dt.Rows[0][3].ToString());
                return employee;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到某一个员工的信息，返回DataTable对象
        /// </summary>
        /// <param name="empid"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeByIdofDataTable(int empid)
        {
            string sql =
                string.Format(
                    "select a.empid as 工号,a.name as 姓名,a.sex as 性别,b.departname as 所在部门 from employee a left join department b on (a.departId=b.id) where empid={0}",
                    empid);
            SQLHelper sh = new SQLHelper();
            DataTable dt = sh.GetData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static DataTable GetEmployeeByCondition(string condition)
        {
            string sql =
                string.Format(
                    "select a.empid as 工号,a.name as 姓名,a.sex as 性别,b.departname as 所在部门 from employee a left join department b on (a.departId=b.id) where {0}",
                    condition);
            SQLHelper sh = new SQLHelper();
            DataTable dt = sh.GetData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

    }
}
