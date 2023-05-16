using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StoreChainShop> InStoreChains { get; set; }
        public ICollection<ShopGood> GoodsInShop { get; set; }
    }
}
