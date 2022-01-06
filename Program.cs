﻿// See https://aka.ms/new-console-template for more information
using AlgorithmsII;


int[] nums = new int[]{5,2,3,6,1};
for (int i = 1; i < nums.Length; i++){
    int j = i;
    while (j - 1 >= 0 && nums[j] < nums[j - 1])
    {
        //swap the two
        
        var temp = nums[j];
        nums[j] = nums[j - 1];
        nums[j - 1] = temp;
        j--;
    }
}