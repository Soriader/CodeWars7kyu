using CodeWars7kyu;

namespace CodeWarsTest;

public class NBalancedNumber
{
    [Test]
    public void NBalancedNumberTest()
    {
        Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(1024));
        Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(66545));
        Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(295591));
        Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(1230987));
        Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(7));
        Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(959));
        Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(13));
        Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(424));
        Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(56239814));
    }
}