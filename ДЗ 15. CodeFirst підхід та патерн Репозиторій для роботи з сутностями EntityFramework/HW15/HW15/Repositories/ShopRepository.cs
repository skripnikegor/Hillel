using HW15.Interfaces;
using HW15.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Repositories
{
    public class ShopRepository : IShopRepository
    {
        protected readonly DbContext _dbContext;
        public ShopRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddShop(Shop shop)
        {
            _dbContext.Set<Shop>().Add(shop);
            _dbContext.SaveChanges();
        }

        public void DeleteShop(Shop shop)
        {
            _dbContext.Set<Shop>().Remove(shop);
            _dbContext.SaveChanges();
        }

        public Shop GetShopById(int Id)
        {
            return _dbContext.Set<Shop>().Find(Id);
        }

        public void UpdateShop(Shop shop)
        {
            _dbContext.Set<Shop>().Update(shop);
            _dbContext.SaveChanges();
        }
    }
}
