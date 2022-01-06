using System;
public class SortDigits {
    public void SortColors(int[] nums) {
        int zeros = 0;
        int ones = 0;
        int twos = 0;
        
        for(var i = 0; i < nums.Length; i ++){
            if(nums[i] == 0){
                zeros++;
            }
            else if(nums[i] == 1){
                ones++;
            }else{
                twos++;
            }
        }
        
        int index = 0;
        for(var i = 0; i < zeros && index < nums.Length; i++){
            nums[index] = 0;
            index++;
        }
        
        for(var i = 0; i < ones && index < nums.Length; i++){
            nums[index] = 1;
            index++;
        }
        
        for(var i = 0; i < twos && index < nums.Length; i++){
            nums[index] = 2;
            index++;
        }
        
    }
}