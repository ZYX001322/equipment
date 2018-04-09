using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 资产管理系统.Model;
using 资产管理系统.DAL;

namespace 资产管理系统.BLL
{
    public class CompanyManager
    {
      public Company GetCompanyInfo()
      {
          Company comp = CompanyDAO.GetInfo();
          return comp;
      }
    }
}
