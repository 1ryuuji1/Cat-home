using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_home_Service
{
    public class PictureCommand
    {
        public Guid CatID { get; set; }

        public Guid PictureID { get; set; }

        public long  UploadTime { get; set; }

        public string Description { get; set; }

    }
}
