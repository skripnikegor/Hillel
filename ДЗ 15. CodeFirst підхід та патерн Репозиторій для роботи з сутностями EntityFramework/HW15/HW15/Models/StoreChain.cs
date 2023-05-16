using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Models
{
    public class StoreChain
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<StoreChainShop> ShopsInStoreChain { get; set; }
    }
}
