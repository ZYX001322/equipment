using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    public class Employee
    {
        private int empId;

        private string sex;

        private int departid;

        private string name;

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int Departid
        {
            get { return departid; }
            set { departid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
