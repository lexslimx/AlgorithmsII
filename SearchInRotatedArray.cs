using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsII
{
    internal class SearchInRotatedArray
    {
        public int Search(int[] nums, int target)
        {
            //[4,5,6,7,0,1,2],,,5
            
            int left = 0;
            int right = nums.Length - 1;
            //int mid = FindMid2(nums);

            int mid = nums.Length == 2 ? 1 : FindMid2(nums);

            if (nums[mid] == target) return mid;

            if (nums[mid] <= target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid;
            }

            Console.WriteLine(mid);
            //4,5,6,7
            //mid =  6
            while (left <= right)
            {
                int midd = left + (right - left) / 2;
                if (nums[midd] == target) return midd;

                if (nums[midd] < target)
                {
                    left = midd + 1;
                }
                else
                {
                    right = midd - 1;
                }
            }

            //do we search the left or right


            return -1;
        }

        private int FindMid2(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                //determine if it's the point of rot
                ////[3,4,5,6,0,1,2]                
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
