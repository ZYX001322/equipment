using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using 资产管理系统.Model;

namespace 资产管理系统.DAL
{
    /// <summary>
    /// 资产管理的一个工厂类
    /// </summary>
    public class ResFactoryDAO
    {
        public static ResoucesDAO CreateResoucesDao(string resType)
        {
            ResoucesDAO resDao = null;
            switch (resType)
            {
                case "eqName":
                    resDao= new EqNameDAO();
                    break;
                case "eqType":
                    resDao=new EqTypeDAO();
                    break;
                case "addType":
                    resDao=new AddTypeDAO();
                    break;
                case "clearType":
                    resDao=new ClearTypeDAO();
                    break;
                case "keepPlace":
                    resDao=new KeepPlaceDAO();
                    break;
                case "unit":
                    resDao=new UnitDAO();
                    break;
            }
            return resDao;
        }

        /// <summary>
        /// 得到所有的资产
        /// </summary>
        /// <param name="resType"></param>
        /// <returns></returns>
        public static DataTable GetAllRes(string resType)
        {
            ResoucesDAO resDao = CreateResoucesDao(resType);
            return resDao.GetAllRes();

        }

        /// <summary>
        /// 根据主键ID来获取资产实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="resType"></param>
        /// <returns></returns>
        public static Resources GetById(int id,string resType)
        {
            ResoucesDAO resDao = CreateResoucesDao(resType);
            return resDao.GetById(id);
        }

        /// <summary>
        /// 添加一个资产实体
        /// </summary>
        /// <param name="res"></param>
        /// <param name="resType"></param>
        /// <returns></returns>
        public static bool Add(Resources res, string resType)
        {
            ResoucesDAO resDao = CreateResoucesDao(resType);
            return resDao.Add(res);
        }

        /// <summary>
        /// 修改一个资产实体
        /// </summary>
        /// <param name="res"></param>
        /// <param name="resType"></param>
        /// <returns></returns>
        public static bool Modify(Resources res, string resType)
        {
            ResoucesDAO resDao = CreateResoucesDao(resType);
            return resDao.Modify(res);
        }

        /// <summary>
        /// 删除一个资产实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="resType"></param>
        /// <returns></returns>
        public static bool Del(int id, string resType)
        {
            ResoucesDAO resDao = CreateResoucesDao(resType);
            return resDao.Del(id);
        }
    }
}
