using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Models
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<ShopGood> PlacedInShops { get; set; }
    }
}
