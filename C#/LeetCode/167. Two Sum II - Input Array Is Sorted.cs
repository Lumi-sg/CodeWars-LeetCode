/*Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.*/

public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int l = 0, i = numbers.Length - 1, sum;
        while (true)
        {
            sum = numbers[l] + numbers[i];
            if (sum == target)
            {
                break;
            }
            else if (sum < target)
            {
                l += 1;
            }
            else
            {
                i -= 1;
            }
        }
        return new[] { l + 1, i + 1 };
    }
}
