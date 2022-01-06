using System;
public class MergeSort{
    public int[] Sort(int[] nums){
        if(nums.Length <= 1) return nums;
        double m = (double)nums.Length/2;
        int mid = (int)Math.Floor(m);
        //split the array into 2
        int[]  left = new int[mid];
        Array.Copy(nums, 0, left, 0, mid);
        
        int[] right = new int[nums.Length - left.Length];
        Array.Copy(nums, mid, right, 0, right.Length);
        int[] l = Sort(left);
        int[] r = Sort(right);
        return Merge(l, r);
    }
    
    private int[] Merge(int[] a, int[] b){
        int[] result = new int[a.Length + b.Length];
        int indexa = 0;
        int indexb = 0;
        int current = 0;
        
        while(indexa < a.Length && indexb < b.Length){
            if(a[indexa] < b[indexb]){
                result[current] = a[indexa];
                current++;
                indexa++;
            }
            else{
                result[current] = b[indexb];
                indexb++;
                current++;
            }
        }
        
        while(indexa < a.Length){
            result[current] = a[indexa];
            current++;
            indexa++;
        }
        
        while(indexb < b.Length){
            result[current] = b[indexb];
            current++;
            indexb++;
        }
        
        return result;
    }
}