using HW15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Interfaces
{
    public interface IStoreChaninRepository
    {
        StoreChain GetStoreChainById(int Id);
        void AddStoreChain(StoreChain storeChain);
        void UpdateStoreChain(StoreChain storeChain);
        void DeleteStoreChain(StoreChain storeChain);
    }
}
