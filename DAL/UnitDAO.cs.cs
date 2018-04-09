using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using 资产管理系统.Model;
using DBUtility;
using System.Data.SqlClient;

namespace 资产管理系统.DAL
{
    /// <summary>
    /// 资产计量单位管理类
    /// </summary>
    public class UnitDAO:ResoucesDAO
    {
        private SQLHelper helper = new SQLHelper();

        public override DataTable GetAllRes()
        {
            string str = "select * from Unit";
            return helper.GetData(str);
        }

        public override Resources GetById(int id)
        {
            string str = string.Format("select * from Unit where Id=" + id);
            DataTable dt = helper.GetData(str);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Unit unit = new Unit();
                unit.Id = int.Parse(row[0].ToString());
                unit.Name = row[1].ToString();
                return unit;
            }
            else
                return null;
        }

        public override bool Add(Resources res)
        {
            string str = string.Format("insert into Unit values('{0}')", res.Name);
            return helper.ExecuteNonQuery(str)>0;
        }

        public override bool Del(int id)
        {
            string str = string.Format("delete from Unit where id={0}", id);
            return helper.ExecuteNonQuery(str) > 0;
        }

        public override bool Modify(Resources res)
        {
            string str = string.Format("update Unit set unit='{0}' where id={1}", res.Name, res.Id);
            return helper.ExecuteNonQuery(str)>0;
        }
    }
}
