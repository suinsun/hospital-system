using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class NewsDAO
    {
        private SQLHelper sqlhelper;
        public NewsDAO()
        {
            sqlhelper = new SQLHelper();

        }
        /// <summary>
        /// 取出最新10条新闻（所属分类，新闻标题，发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            return sqlhelper.ExecuteQuery("procNewsSeleteNewNews", CommandType.StoredProcedure);
        }
        /// <summary>
        /// 取出十条热点新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotNews()
        {

            DataTable dt = new DataTable();
            return dt;
        }
        /// <summary>
        /// 根据类别ID取出该类别下的所有新闻
        /// </summary>
        /// <param name="caId">类别ID</param>
        /// <returns></returns>

        public DataTable SelectByCaId(string caId)
        {

            DataTable dt = new DataTable();
            string cmdText = "news_SelectByCaId";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter ("@caId",caId )
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 根据新闻ID取出该条新闻主要内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public News SelectById(string id)
        {

            News n = new News();
            DataTable dt = new DataTable();
            string cmdText = "news_SelectById";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter ("@id",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            n.Id = id;
            n.Title = dt.Rows[0]["title"].ToString();
            n.Content = dt.Rows[0]["content"].ToString();
            n.CreateTime = dt.Rows[0]["createTime"].ToString();
            n.CaId = dt.Rows[0]["caId"].ToString();


            return n;
        }
        /// <summary>
        /// 根据标题搜索新闻
        /// </summary>
        /// <param name="title">新闻标题</param>
        /// <returns></returns>

        public DataTable SelectByTitle(string title)
        {
            DataTable dt = new DataTable();
            string cmdText = "news_SelectByTitle";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter ("@title",title)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);

            return dt;
        }
        /// <summary>
        /// 根据内容搜索新闻
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>

        public DataTable SelectByContent(string content)
        {
            DataTable dt = new DataTable();
            string cmdText = "news_SelectByContent";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter ("@content",content)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);

            return dt;
        }
        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public bool Insert(News n)
        {

            bool flag = false;
            string cmdText = "news_Insert";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter ("@title",n.Title ),
            new SqlParameter ("@content",n.Content ),
            new SqlParameter ("@caId",n.CaId )
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public bool Update(News n)
        {
            bool flag = false;
            string cmdText = "news_Updata";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter ("@id",n.Id),
            new SqlParameter ("@title",n.Title ),
            new SqlParameter ("@content",n.Content ),
            new SqlParameter ("@caId",n.CaId )
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 删除新闻（连同其下新闻评论一起删除）
        /// </summary>
        /// <param name="id">评论ID</param>
        /// <returns></returns>

        public bool Delete(string id)
        {

            bool flag = false;
            string cmdText = "news_Delete";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter ("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
