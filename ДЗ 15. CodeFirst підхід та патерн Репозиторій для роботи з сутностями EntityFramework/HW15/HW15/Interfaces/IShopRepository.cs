using HW15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Interfaces
{
    public interface IShopRepository
    {
        Shop GetShopById(int Id);
        void AddShop(Shop shop);
        void UpdateShop(Shop shop);
        void DeleteShop(Shop shop);
    }
}
