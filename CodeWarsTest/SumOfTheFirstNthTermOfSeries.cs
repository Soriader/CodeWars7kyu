using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfTheFirstNthTermOfSeries
{
    [Test]
    public void SumOfTheFirstNthTermOfSeriesTest()
    {
        Assert.AreEqual("0.00", SumOfTheFirstNthTermOfSeriesTask.SeriesSum(0));
        Assert.AreEqual("1.77", SumOfTheFirstNthTermOfSeriesTask.SeriesSum(9));

    }
}