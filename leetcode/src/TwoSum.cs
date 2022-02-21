namespace Leetcode;

public class TwoSum
{
    public (bool, int[]?) Find(int[] array, int target)
    {
        var cache = new Dictionary<int, int>();
        for (var i = 0; i < array.Length; i++)
        {
            var first = array[i];
            var second = target - first;
            if (cache.TryGetValue(second, out int index))
            {
                return (true, new int[] { index, i });
            }
            cache[first] = i;
        }
        return (false, null);
    }
}
