namespace AlgorithmsII
{
    public class FirstAndLastPosition
    {
        public int[] SearchRange(int[] nums, int target)
        {
            List<int> positions = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    positions.Add(i);
                }
            }

            if (positions.Count == 0) return new int[] { -1, -1 };
            return new int[] { positions.FirstOrDefault(), positions.LastOrDefault() }; //bad time complexity
        }
    }
}