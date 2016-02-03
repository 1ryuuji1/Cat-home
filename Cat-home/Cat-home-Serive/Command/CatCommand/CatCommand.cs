using System;
using System.Collections.Generic;

namespace Cat_home_Serive
{
    class CatCommand
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 猫的名字
        /// </summary>
        public string CatName { get; set; }

        /// <summary>
        /// 猫的种类
        /// </summary>
        public string Species { get; set; }

        /// <summary>
        /// 猫的生日 时间戳
        /// </summary>
        public long Birthday { get; set; }

        /// <summary>
        /// 猫妈妈的名字
        /// </summary>
        public string MamName { get; set; }

        /// <summary>
        /// 猫妈妈的ID
        /// </summary>
        public Guid MamID { get; set; }

        /// <summary>
        /// 猫爸爸的名字
        /// </summary>
        public string DadName { get; set; }

        /// <summary>
        /// 猫爸爸的ID
        /// </summary>
        public Guid DadID { get; set; }

        /// <summary>
        /// 猫的照片的集合
        /// </summary>
        public string Piceture { get; set; }

        /// <summary>
        /// 猫的毛色花纹
        /// </summary>
        public string Coat { get; set; }

        /// <summary>
        /// 猫的得奖经历
        /// </summary>
        public ICollection<AwardsCommand> Awards { get; set; }

        /// <summary>
        /// 猫的级别，宠物级赛级繁育级
        /// </summary>
        public Enum.CatStatus CatStatus { get; set; }

        /// <summary>
        /// 猫的性别
        /// </summary>
        public Enum.Gender Gender { get; set; }

        /// <summary>
        /// 猫的主人的信息
        /// </summary>
        public HostPersonCommand Host { get; set; }

        /// <summary>
        /// 猫的绝育状态
        /// </summary>
        public Enum.SterilizationStatus SterilizationStatus { get; set; }

        /// <summary>
        /// 猫的疫苗状态
        /// </summary>
        public string Vaccine { get; set; }

        /// <summary>
        /// 猫的血统证书ID
        /// </summary>
        public string PedigreeID { get; set; }

        /// <summary>
        /// 猫的基因型
        /// </summary>
        public string Genotype { get; set; }

        /// <summary>
        /// 猫的DNA鉴定扫描件
        /// </summary>
        public string DNA { get; set; }

        /// <summary>
        /// 猫的销售状态
        /// </summary>
        public Enum.SaleStatus SaleStatus { get; set; }

        public ICollection<PictureCommand> Picture { get; set; }
    }
}
