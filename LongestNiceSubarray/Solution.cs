using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestNiceSubarray
{
    public class Solution
    {
        public int LongestNiceSubarray(int[] nums)
        {
            int i = 0, j = 0, n = nums.Length;
            int mask = 0, max = 0;
            while (i <= j && j < n)
            {
                if ((mask & nums[j]) == 0)
                {
                    mask |= nums[j];
                    j++;
                    max = Math.Max(max, j - i);
                }
                else
                {
                    mask ^= nums[i];
                    i++;
                }
            }
            return max;
        }
    }
}
