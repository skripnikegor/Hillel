using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Models
{
    public class StoreChainShop
    {
        public int StoreChainId { get; set; }
        public StoreChain StoreChain { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
