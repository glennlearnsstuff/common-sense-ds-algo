using Xunit;

namespace Leetcode.Tests;

public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, true, 0, 1)]
    [InlineData(new int[] { 3, 2, 4 }, 6, true, 1, 2)]
    [InlineData(new int[] { 3, 3 }, 6, true, 0, 1)]
    public void FindTest(int[] input, int target, bool found, int indexOne, int indexTwo)
    {
        var expected = (Item1: found, new int[] { indexOne, indexTwo });
        var actual = new TwoSum().Find(input, target);
        Assert.Equal(expected.Item1, actual.Item1);
        Assert.Equal(expected.Item2, actual.Item2);
    }
}