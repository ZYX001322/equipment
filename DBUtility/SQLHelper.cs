using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;

namespace DBUtility
{
    public class SQLHelper
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;

        /// <summary>
        /// 得到数据
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns></returns>
        public DataTable GetData(string sql)
        {

            try
            {
                this.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                this.da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 对数据进行 增 删 改 的操作
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                this.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                this.cmd = new SqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {

                return 0;
            }
            finally
            {
                conn.Close();
            }


        }

        /// <summary>
        ///返回查询结果集的首行首列值
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>object</returns>
        public int ExecuteScalar(string sql)
        {
            try
            {
                this.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                this.cmd = new SqlCommand(sql, conn);
                return int.Parse(this.cmd.ExecuteScalar().ToString());
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }


        }
   
        /// <summary>
        /// 数据查询(有参数的查询)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandParameters"></param>
        /// <returns></returns>
        public DataTable GetData(string sql, params SqlParameter[] commandParameters)
        {           
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            cmd = new SqlCommand(sql,conn);
            for (int i = 0; i < commandParameters.Length; i++)
            {
                cmd.Parameters.Add(commandParameters[i]);
            }
            try
            {
                this.conn.Open();
                this.da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                this.da.Fill(dt);

                return dt;
            }
            catch
            {

                return null;
            }

            finally
            {
                if (this.cmd != null) cmd.Dispose();
                if (this.da != null) this.da.Dispose();
                this.conn.Close();
            }
        }
        /// <summary>
        /// 执行大容量数据的添加删除修改操作
        /// </summary>
        /// <param name="Pname">代参SQL语句</param>
        /// <param name="commandParameters">SQL中的参数</param>
        /// <returns>result:sql对数据表影响的行数</returns>
        public int ExecuteSQL(string sql, params SqlParameter[] commandParameters)
        {
            this.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            cmd = new SqlCommand(sql, conn);
            for (int i = 0; i < commandParameters.Length; i++)
            {
                cmd.Parameters.Add(commandParameters[i]);
            }
            try
            {
                this.conn.Open();
                int result = this.cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {

                return 0;
            }

            finally
            {
                if (this.cmd != null) cmd.Dispose();
                this.conn.Close();
            }
        }
        /// <summary>
        /// 返回结果集分页
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="start">起始条数(从0开始) start+1 -- start+max</param>
        /// <param name="max">分页条数</param>
        public DataTable GetData(string cmdText, int start, int max)
        {
            //this.conn = new SqlConnection(ConfigurationSettings.AppSettings["con"]);
            //创建一个新的数据适配器
            SqlDataAdapter custDA = new SqlDataAdapter();
            //创建一个新的 SqlCommand 对象
            SqlCommand cmd = new SqlCommand();

            //创建连接
            using (this.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                cmd.CommandText = cmdText;
                cmd.Connection = conn;
                custDA.SelectCommand = cmd;
                DataSet ds = new DataSet();
                try
                {
                    custDA.Fill(ds, start, max, "data");
                }
                catch
                {
                    return null;
                }
                return ds.Tables["data"];
            }
        }
    }
}
