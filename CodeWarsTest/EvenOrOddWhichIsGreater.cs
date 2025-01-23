using CodeWars7kyu;

namespace CodeWarsTest;

public class EvenOrOddWhichIsGreater
{
    [Test]
    public void EvenOrOddWhichIsGreaterTest()
    {
        Assert.AreEqual("Odd is greater than Even", EvenOrOddWhichIsGreaterTask.EvenOrOdd("123"));
        Assert.AreEqual("Even is greater than Odd", EvenOrOddWhichIsGreaterTask.EvenOrOdd("12"));
        Assert.AreEqual("Even and Odd are the same", EvenOrOddWhichIsGreaterTask.EvenOrOdd("112"));
    }
}