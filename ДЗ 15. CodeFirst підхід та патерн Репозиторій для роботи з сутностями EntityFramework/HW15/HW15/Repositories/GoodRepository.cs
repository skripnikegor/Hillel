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
    public class GoodRepository : IGoodRepository
    {
        private readonly DbContext _dbContext;

        public GoodRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddGood(Good good)
        {
            _dbContext.Set<Good>().Add(good);
            _dbContext.SaveChanges();
        }

        public void DeleteGood(Good good)
        {
            _dbContext.Set<Good>().Remove(good);
            _dbContext.SaveChanges();
        }

        public Good GetGoodById(int Id)
        {
            return _dbContext.Set<Good>().Find(Id);
        }

        public void UpdateGood(Good good)
        {
            _dbContext.Set<Good>().Update(good);
            _dbContext.SaveChanges();
        }
    }
}
