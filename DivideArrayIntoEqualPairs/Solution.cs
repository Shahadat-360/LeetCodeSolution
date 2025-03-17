using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideArrayIntoEqualPairs
{
    public class Solution
    {
        public bool DivideArray(int[] nums)
        {
            return nums.GroupBy(x => x).All(g => g.Count() % 2 == 0);
        }
    }
}
