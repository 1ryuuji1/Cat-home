using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_home_Serive
{
    public class AwardsCommand
    {
        /// <summary>
        /// 比赛名
        /// </summary>
        public string AwardsName { get; set; }

        /// <summary>
        /// id
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public long Date { get; set; }

        /// <summary>
        /// 名次
        /// </summary>
        public string Places { get; set; }

        /// <summary>
        /// 地点
        /// </summary>
        public string Location { get; set; }
    }
}
