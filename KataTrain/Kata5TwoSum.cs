using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTrain
{
    class Kata5TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            int[] retn = new int[2];
            Dictionary<int, int> mydic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (mydic.ContainsKey(target - nums[i]))
                {
                    retn[1] = i;
                    retn[0] = mydic[target - nums[i]];
                }
                else
                {
                    mydic[nums[i]] = i;
                }
            }
            return retn;

        }
    }
}
