using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
     public  class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var length = s.Length;
            var result = 0;
            var max = 0;
            var temp = "";
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            if (s.Replace(s[0], ' ').Trim() == "")
            {
                return 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                temp += s[i];
                result = 1;
                for (int j = i + 1; j < s.Length; j++)
                {

                    if (!temp.Contains(s[j].ToString()))
                    {
                        result++;
                        temp += s[j];
                    }
                    else break;
                }
                temp = "";
                if (result > max)
                {
                    max = result;
                }
            }
            return max;
        }

        
    }
}
