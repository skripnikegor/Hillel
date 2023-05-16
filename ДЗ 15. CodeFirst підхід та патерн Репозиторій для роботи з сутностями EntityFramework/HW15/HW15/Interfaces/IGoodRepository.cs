using HW15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Interfaces
{
    public interface IGoodRepository
    {
        Good GetGoodById(int Id);
        void AddGood(Good good);
        void UpdateGood(Good good);
        void DeleteGood(Good good);
    }
}
