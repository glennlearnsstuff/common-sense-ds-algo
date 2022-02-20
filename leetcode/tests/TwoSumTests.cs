using Xunit;

namespace Leetcode.Tests;

public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void FindTest(int[] input, int target, int[] correctIndex)
    {
        var twoSum = new TwoSum();
        var result = twoSum.Find(input, target);
        Assert.Equal(correctIndex, result);
    }
}