using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Models
{
    public class ShopGood
    {
        public int GoodId { get; set; }
        public Good Good { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
