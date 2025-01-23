using CodeWars7kyu;

namespace CodeWarsTest;

public class DigitalCypher
{
    [Test]
    public void DigitalCypherTest()
    {
        Assert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, DigitalCypherTask.Encode("scout", 1939));
        Assert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, DigitalCypherTask.Encode("masterpiece", 1939));

    }
}