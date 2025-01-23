using CodeWars7kyu;

namespace CodeWarsTest;

public class DigitalCypherTwo
{
    [Test]
    public void DigitalCypherTwoTest()
    {
        Assert.AreEqual("scout", DigitalCypherTwoTask.Decode(new int[] { 20, 12, 18, 30, 21 }, 1939));
        Assert.AreEqual("masterpiece", DigitalCypherTwoTask.Decode(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, 1939));
    }
}