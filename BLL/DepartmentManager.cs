using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 资产管理系统.Model;
using 资产管理系统.DAL;
using System.Data;

namespace 资产管理系统.BLL
{
    public class DepartmentManager
    {
        public DataTable GetDeptInfo()
        {
            DataTable dt = DepartmentDAO.GetAllDepartments();
            if (dt!=null)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public bool AddDept(Department dept)
        {
            return DepartmentDAO.AddDepartment(dept);
        }

        public bool DelDept(int id)
        {
            return DepartmentDAO.DelDepartment(id);
        }

        public bool UpadateDept(Department dept)
        {
            return DepartmentDAO.UpateDepartment(dept);
        }
    }
}
