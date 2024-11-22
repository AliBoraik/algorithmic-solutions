namespace LeetCode.Tasks;

public class NextGreaterElementI
{
    /*
        The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.
       
       You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.
       
       For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2. If there is no next greater element, then the answer for this query is -1.
       
       Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.
     */
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        if( nums1.Length == 0)
            return [];
        var dic = new Dictionary<int,int>();
        var stack = new Stack<int>();

        foreach(var num in nums2)
        {
            while(stack.Count > 0 && stack.Peek() < num)
            {
                dic.Add(stack.Pop(), num);
            }

            stack.Push(num);
        }

        int[] res = new int[nums1.Length];
        for(int i = 0; i < res.Length; i++)
        {
            res[i] = dic.ContainsKey(nums1[i])? dic[nums1[i]] : -1;
        }

        return res;
    }
}