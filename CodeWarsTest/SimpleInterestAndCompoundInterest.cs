using CodeWars7kyu;

namespace CodeWarsTest;

public class SimpleInterestAndCompoundInterest
{
    [Test]
    public void SimpleInterestAndCompoundInterestTest()
    {
        Assert.AreEqual(new int[2] { 110, 110 }, SimpleInterestAndCompoundInterestTask.Interest(100, 0.1, 1));
        Assert.AreEqual(new int[2] { 120, 121 }, SimpleInterestAndCompoundInterestTask.Interest(100, 0.1, 2));
        Assert.AreEqual(new int[2] { 200, 259 }, SimpleInterestAndCompoundInterestTask.Interest(100, 0.1, 10));
    }
}