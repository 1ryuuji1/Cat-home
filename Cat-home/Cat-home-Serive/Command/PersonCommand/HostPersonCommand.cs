using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_home_Serive
{
    public class HostPersonCommand

    {
        /// <summary>
        /// 主人的ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 主人的名字
        /// </summary>
        public string Name { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// 主人的猫的ID 
        /// </summary>
        public Guid CatID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public string Competence { get; set; }
    }
}
