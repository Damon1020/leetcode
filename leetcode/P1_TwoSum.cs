using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class P1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("NO two sum solution!");
        }

        /// <summary>
        /// other people's solution of leetcode discuss
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum_otherPeople(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (Array.IndexOf(nums, target - nums[i]) != -1)
                {
                    return new int[] {i,Array.IndexOf(nums,target-nums[i])};
                }
            }
            throw new ArgumentException("NO two sum solution!");
        }

        /// <summary>
        /// P1_TwoSum test
        /// </summary>
        public void P1_TwoSum_Test()
        {
            int[] nums = { 3, 6, 9, 666 };
            int target = 12;
            try
            {
                //int[] result = TwoSum(nums, target);
                int[] result = TwoSum_otherPeople(nums, target);
                foreach (int n in result)
                {
                    Console.Write(n + "  ");
                }
                Console.WriteLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("NO two sum solution!!!");
            }
            finally
            {
                Console.WriteLine("have done");
            }
        }

    }
}
