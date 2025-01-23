using CodeWars7kyu;

namespace CodeWarsTest;

public class IsEvenBitwiseSeries
{
    [Test]
    public void IsEvenBitwiseSeriesTest()
    {
        Assert.AreEqual(true, IsEvenBitwiseSeriesTask.IsEven(2), "2 is even");
        Assert.AreEqual(false, IsEvenBitwiseSeriesTask.IsEven(3), "3 is odd");
        Assert.AreEqual(true, IsEvenBitwiseSeriesTask.IsEven(14), "14 is even");
        Assert.AreEqual(false, IsEvenBitwiseSeriesTask.IsEven(15), "15 is odd");
        Assert.AreEqual(true, IsEvenBitwiseSeriesTask.IsEven(26), "26 is even");
        Assert.AreEqual(false, IsEvenBitwiseSeriesTask.IsEven(27), "27 is odd");
    }
}