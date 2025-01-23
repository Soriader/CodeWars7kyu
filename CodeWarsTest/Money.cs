using CodeWars7kyu;

namespace CodeWarsTest;

public class Money
{
    [Test]
    public void MoneyTest()
    {
        Assert.AreEqual(0, MoneyTask.CalculateYears(1000, 0.05, 0.18, 1000));
        Assert.AreEqual(14, MoneyTask.CalculateYears(1000, 0.01625, 0.18, 1200));

    }
}