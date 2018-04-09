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
    /// 资产名称表的管理类
    /// </summary>
    public class EqNameDAO:ResoucesDAO
    {
        private SQLHelper helper=new SQLHelper();
        public override DataTable GetAllRes()
        {
            string str = "select * from EqName";  
            return helper.GetData(str);         
        }

        public override Resources GetById(int id)
        {
            string str = string.Format("select * from EqName where id="+id);
            DataTable dt = helper.GetData(str);
            if (dt!=null&&dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                EqName eqName=new EqName();
                eqName.Id = int.Parse(dr[0].ToString());
                eqName.Name = dr[1].ToString();
                return eqName;
            }
            else
            {
                return null;
            }
        }

        public override bool Add(Resources res)
        {
            string str = string.Format("insert into EqName values('{0}')", res.Name);           
            return helper.ExecuteNonQuery(str)>0;
        }

        public override bool Del(int id)
        {
            string str=string.Format("delete from EqName where id='{0}',id");
            return helper.ExecuteNonQuery(str) > 0;
        }

        public override bool Modify(Resources res)
        {
            string str=string.Format("update EqName set name='{0}' where id={1}",res.Name,res.Id);
            return helper.ExecuteNonQuery(str) > 0;
        }
    }
}
