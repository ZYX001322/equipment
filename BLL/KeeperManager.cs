using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using 资产管理系统.DAL;
using 资产管理系统.Model;

namespace 资产管理系统.BLL
{
    public class KeeperManager
    {
        public DataTable BingListBox()
        {
            DataTable dt = KeeperDAO.GetAllKeepers();
            return dt;
        }

        public bool DeleteKeeper(int id)
        {
            return KeeperDAO.DelKeeper(id);
        }

        public bool AddKeeper(Keeper keeper)
        {
            return KeeperDAO.AddKeeper(keeper);
        }
    }
}
