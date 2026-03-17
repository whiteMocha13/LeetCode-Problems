/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false; 
        
        List<int> digits = new List<int>();
        
        do
        {
            digits.Add(x % 10); 
            x /= 10;
        }
        while(x > 0);
        
        int lastIndex = digits.Count - 1 ; 
        
        for (int firstIndex = 0 ; firstIndex < digits.Count; firstIndex++)
        {
            
            if (digits[lastIndex] == digits[ firstIndex])
            {
                lastIndex--; 
                continue;
            }
            else
            return false; 
        }
        return true;
        //1, 2, 3, 7
    }
}
// @lc code=end
