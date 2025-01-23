using CodeWars7kyu;

namespace CodeWarsTest;

public class MaximumTripletSum
{
    [Test]
    public void MaximumTripletSumTest()
    {
        Assert.AreEqual(0, MaximumTripletSumTask.MaxTriSum(new int[] { -2, 0, 2 }));
        Assert.AreEqual(17, MaximumTripletSumTask.MaxTriSum(new int[] { 3, 2, 6, 8, 2, 3 }));
        Assert.AreEqual(-9, MaximumTripletSumTask.MaxTriSum(new int[] { -3, -27, -4, -2, -27, -2 }));
        Assert.AreEqual(232, MaximumTripletSumTask.MaxTriSum(new int[] { -13, -50, 57, 13, 67, -13, 57, 108, 67 }));

    }
}