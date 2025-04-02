using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueOfAnOrderedTripletI
{
    public class Solution
    {
        public long MaximumTripletValue(int[] nums)
        {
            long maxDiff = 0;
            long maxk = 0;
            long result = 0;
            for (int k = 0; k < nums.Length; k++)
            {
                result = Math.Max(result, maxDiff * nums[k]);
                maxDiff = Math.Max(maxDiff, maxk - nums[k]);
                maxk = Math.Max(maxk, nums[k]);
            }
            return result;
        }
    }
}
