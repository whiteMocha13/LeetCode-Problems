/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] Output = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int tryout = 1; tryout + i < nums.Length; tryout++)
            {
                if ((nums[i] + nums[i + tryout]) == target)
                {
                    Output[0] = i;
                    Output[1] = i + tryout;
                    return Output;
                }
            }
        }
        return null;
    }
}
// @lc code=end

