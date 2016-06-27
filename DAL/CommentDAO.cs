﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class CommentDAO
    {
        private SQLHelper sqlhelper;
        public CommentDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 根据新闻ID取出该新闻的所有评论
        /// </summary>
        /// <param name="newsId">新闻ID</param>
        /// <returns></returns>
        public DataTable SelectByNewsId(string newsId)
        {
            DataTable dt = new DataTable();
            string sql = "select * from comment where newsId=@newsId order by createTime desc ";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter ("@newsId",newsId )
            };
            dt = sqlhelper.ExecuteQuery(sql, paras, CommandType.Text);
            return dt;

        }

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="c">评论实体类</param>
        /// <returns></returns>

        public bool Insert(Comment c)
        {
            bool flag = false;
            string sql = "insert into comment([content],userIp,newsId) values(@content,@userIp,@newsId)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter ("@content",c.Content ),
                new SqlParameter ("@userIp",c.UserIp ),
                new SqlParameter ("@newsId",c.NewsId)};
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete comment where id=@id";
            SqlParameter[] paras = new SqlParameter[] { 
                new SqlParameter ("@id",id)};
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

    }
}
