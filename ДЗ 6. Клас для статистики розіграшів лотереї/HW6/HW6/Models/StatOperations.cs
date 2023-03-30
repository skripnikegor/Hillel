using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.Models
{
    public static class StatOperations
    {
        public static IEnumerable<int> NeverAppeared(IEnumerable<int> emit)
        {
            var range = Enumerable.Range(0 ,emit.Count());
            return range.Except(emit);
        }

        public static Dictionary<int, int> MostAppeared(List<int> emit, int N)
        {
            return new Dictionary<int, int>();
        }
    }
}
