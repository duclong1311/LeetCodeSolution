//26. Remove Duplicates from Sorted Array   
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        for (int i = 0; i < nums.Length; i++){
            if (nums[k] != nums[i]){
                k++;
                nums[k] = nums[i];
            }
        }
        return k + 1;
    }
}