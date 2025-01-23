using CodeWars7kyu;

namespace CodeWarsTest;

public class UnluckyDays
{
    [Test]
    public void UnluckyDaysTest()
    {
        Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(1586));
        Assert.AreEqual(3, UnluckyDaysTask.UnluckyDays(1001));
        Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2819));
        Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2792));
        Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2723));
        Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(1909));
        Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(1812));
        Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(1618));
        Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(2132));
        Assert.AreEqual(3, UnluckyDaysTask.UnluckyDays(2065));
    }
}