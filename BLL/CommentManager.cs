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
    class CommentManager
    {
        private CommentDAO codao = null;
        public CommentManager()
        {
            codao = new CommentDAO();
        }
        #region 根据新闻ID取出该新闻的所有评论
        /// <summary>
        /// 根据新闻ID取出该新闻的所有评论
        /// </summary>
        /// <param name="newsId">新闻ID</param>
        /// <returns></returns>
        public DataTable SelectByNewsId(string newsId)
        {
            return codao.SelectByNewsId(newsId);
        }
        #endregion

        #region 添加评论
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="c">评论实体类</param>
        /// <returns></returns>

        public bool Insert(Comment c)
        {
            return codao.Insert(c);
        }
        #endregion

        #region 删除评论
        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="id">评论ID</param>
        /// <returns></returns>

        public bool Delete(string id)
        {
            return codao.Delete(id);
        }
        #endregion

    }
}
