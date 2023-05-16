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
    public class StoreChainRepository : IStoreChaninRepository
    {
        protected readonly DbContext _dbContext;
        public StoreChainRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddStoreChain(StoreChain storeChain)
        {
            _dbContext.Set<StoreChain>().Add(storeChain);
        }

        public void DeleteStoreChain(StoreChain storeChain)
        {
            _dbContext.Set<StoreChain>().Remove(storeChain);
        }

        public StoreChain GetStoreChainById(int Id)
        {
            return _dbContext.Set<StoreChain>().Find(Id);
        }

        public void UpdateStoreChain(StoreChain storeChain)
        {
            _dbContext.Set<StoreChain>().Update(storeChain);
        }
    }
}
