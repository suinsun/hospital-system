/*
 *制作人：酥梨
 *创建时间：2012-5-25 0:08
 *说明：新闻类别实体类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 新闻评论实体类
    /// </summary>
    public class Comment
    {
        private string id;
        /// <summary>
        /// 主键，自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string content;
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string userIp;
        /// <summary>
        /// 评论人IP
        /// </summary>
        public string UserIp
        {
            get { return userIp ; }
            set { userIp  = value; }
        }

        private string newsId;
        /// <summary>
        /// 所属新闻ID
        /// </summary>
        public string NewsId
        {
            get { return newsId ; }
            set { newsId  = value; }
        }
        public Comment()
        { }
        public Comment(string content, string userIp, string newsId)
        {
            this.content = content;
            this.userIp = userIp;
            this.newsId = newsId;
        }
    }
}


