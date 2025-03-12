using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSubstringsContainingAllThreeCharacters
{
    public class Solution
    {
        //problem link: https://leetcode.com/problems/number-of-substrings-containing-all-three-characters/
        public int NumberOfSubstrings(string s)
        {
            int count = 0;
            Dictionary<char, int> lastSeen = new() {
        { 'a', -1 }, { 'b', -1 }, { 'c', -1 }
        };

            for (int i = 0; i < s.Length; i++)
            {
                lastSeen[s[i]] = i;
                if (lastSeen.Min(x => x.Value) != -1)
                {
                    count += lastSeen.Min(x => x.Value) + 1;
                }
            }
            return count;
        }
    }
}
