﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsII
{
    public class FindPeakElement
    {
        public int FindPeakElements(int[] nums)
        {
            return search(nums, 0, nums.Length - 1);
        }
        public int search(int[] nums, int l, int r)
        {
            if (l == r)
                return l;
            int mid = l + (r - l) / 2;
            if (nums[mid] > nums[mid + 1])
                return search(nums, l, mid);
            return search(nums, mid + 1, r);
        }
    }
}
