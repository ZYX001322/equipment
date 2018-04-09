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
    /// 资产类型管理类
    /// </summary>
    public class EqTypeDAO:ResoucesDAO
    {
        private SQLHelper helper=new SQLHelper();

        public override DataTable GetAllRes()
        {
            string str="select * from Type";
            return helper.GetData(str);
        }

        public override Resources GetById(int id)
        {
            string str=string.Format("select * from Type where id="+id);
            DataTable dt = helper.GetData(str);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                EqType eqType = new EqType();
                eqType.Id = int.Parse(row[0].ToString());
                eqType.Name = row[1].ToString();
                return eqType;
            }
            else
                return null;
        }

        public override bool Add(Resources res)
        {
            string strsql = string.Format("insert into Type values('{0}')", res.Name);
            return helper.ExecuteNonQuery(strsql)>0; ;
        }

        public override bool Del(int id)
        {
            string strsql = string.Format("delete from Type where id={0}", id);
            return helper.ExecuteNonQuery(strsql)>0;
        }

        public override bool Modify(Resources res)
        {
            string strsql = string.Format("update Type set Type='{0}' where id={1}", res.Name, res.Id);
            return helper.ExecuteNonQuery(strsql)>0;
        }
    }
}
