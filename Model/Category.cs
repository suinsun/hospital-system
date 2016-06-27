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
    /// 新闻类别实体类
    /// </summary>
    public class Category
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

        private string name;
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Category(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
