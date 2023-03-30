using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.Models
{
    public static class StatOperations
    {
        public static IEnumerable<int> NeverAppeared(IEnumerable<IEnumerable<int>> emits)
        {
            var uniqueValues = new HashSet<int>();

            foreach (var em in emits)
            {
                uniqueValues.UnionWith(em);
            }

            for (int i = 1; i < uniqueValues.Count; i++)
            {
                if (!uniqueValues.Contains(i))
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> MostAppeared(IEnumerable<IEnumerable<int>> emits, int n)
        {
            var counts = new Dictionary<int, int>();

            foreach (var em in emits)
            {
                foreach (var number in em)
                {
                    if (!counts.ContainsKey(number))
                    {
                        counts[number] = 0;
                    }
                    counts[number]++;
                }
            }
            return counts.OrderByDescending(pair => pair.Value).Take(n).Select(pair => pair.Key).ToList();
        }
    }
}
