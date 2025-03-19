using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationsToMakeBinaryArrayElementsEqualToOneI
{
    public class Solution
    {
        public int MinOperations(int[] nums)
        {
            int n = nums.Length, c = 0;
            for (int i = 0; i <= n - 3; i++)
            {
                if (nums[i] == 1) continue;
                (nums[i], nums[i + 1], nums[i + 2]) = (1, 1 - nums[i + 1], 1 - nums[i + 2]);
                c++;
            }
            return nums.Sum() == n ? c : -1;
        }
    }
}
