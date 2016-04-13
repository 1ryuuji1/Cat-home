using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_home_Service

{
    public class Enum
    {
        public enum CatStatus
        {

        }

        public enum Gender
        {
            boy = 0,
            girl
        }

        public enum SterilizationStatus
        {
            yes = 0,
            no
        }

        public enum SaleStatus
        {
            onsale=0,
            outsale=1

        }

        public enum PersonStatus
        {
            admin=0,
            customer,
            tourist
        }
    }
}
