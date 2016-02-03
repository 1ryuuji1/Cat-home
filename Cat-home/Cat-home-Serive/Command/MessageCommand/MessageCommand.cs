using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_home_Serive
{
    public class MessageCommand
    {
        public Guid ID { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string MessageContent { get; set; }

        /// <summary>
        /// 留言日期
        /// </summary>
        public long CreateDate { get; set; }

        public Guid VisitorID { get; set; }
    }
}
