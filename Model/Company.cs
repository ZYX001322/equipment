using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 资产管理系统.Model
{
    public class Company
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string master;

        public string Master
        {
            get { return master; }
            set { master = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
