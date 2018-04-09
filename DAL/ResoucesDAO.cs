using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using 资产管理系统.Model;

namespace 资产管理系统.DAL
{
    /// <summary>
    /// 一个抽象的资产管理基类
    /// </summary>
    public abstract class ResoucesDAO
    {
        /// <summary>
        /// 得到所有的资产
        /// </summary>
        /// <returns></returns>
        public abstract DataTable GetAllRes();

        /// <summary>
        /// 根据主键Id来获取资产实体
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns>资产实体</returns>
        public abstract Resources GetById(int id);

        /// <summary>
        /// 增加一个资产
        /// </summary>
        /// <param name="name"></param>
        public abstract bool Add(Resources res);

        /// <summary>
        /// 删除一个资产
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public abstract bool Del(int id);

        /// <summary>
        /// 修改一个资产
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public abstract bool Modify(Resources res);
    }
}
