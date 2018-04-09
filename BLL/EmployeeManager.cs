using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using 资产管理系统.DAL;
using 资产管理系统.Model;


namespace 资产管理系统.BLL
{
    public class EmployeeManager
    {
         public DataTable GetAllEmpByDeptID(int deptid)
         {
             return EmployeeDAO.GetAllEmpByDeptID(deptid);
         }

        public DataTable GetAllEmployees()
        {
            return EmployeeDAO.GetAllEmployees();
        }

        public DataTable GetEmployeeByIdofDataTable(int empId)
        {
            return EmployeeDAO.GetEmployeeByIdofDataTable(empId);
        }

        public DataTable GetEmployeeByCondition(string condition)
        {
            return EmployeeDAO.GetEmployeeByCondition(condition);
        }

        public bool AddEmployee(Employee emp)
        {
            return EmployeeDAO.AddEmployee(emp);
        }

        public bool UpdateEmployee(Employee emp)
        {
            return EmployeeDAO.UpdateEmployee(emp);
        }

        public Employee GetEmployeeById(int empid)
        {
            return EmployeeDAO.GetEmployeeById(empid);
        }

        public int DelEmployee(int empid)
        {
            return EmployeeDAO.DelEmployee(empid);
        }
    }
}
