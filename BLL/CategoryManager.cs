/*
 *制作人：酥梨
 *创建时间：2012-5-28 21:39
 *说明：新闻类别表的业务类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CategoryManager
    {
        private CategoryDAO cdao = null;
        public CategoryManager()
        {
            cdao = new CategoryDAO();
        }
        #region 取出当前所有新闻分类
        /// <summary>
        /// 取出当前所有新闻分类
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            return cdao.SelectAll();

        }
        #endregion

        #region 增加类别
        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Insert(string caName)
        {
            return cdao.Insert(caName);
        }
        #endregion

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>

        public bool Update(Category ca)
        {
            return cdao.Update(ca);
        }
        #endregion

        #region 删除类别
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>

        public bool Delete(string id)
        {

            return cdao.Delete(id);
        }

        #endregion

        #region 判断类别名称是否已存在
        /// <summary>
        /// 判断类别名称是否已存在
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool IsExists(string caName)
        {
            return cdao.IsExists(caName);
        }
        #endregion

    }
}
