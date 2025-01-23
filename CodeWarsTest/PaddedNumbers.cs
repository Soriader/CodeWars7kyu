using CodeWars7kyu;

namespace CodeWarsTest;

public class PaddedNumbers
{
    [Test]
    public void PaddedNumbersTest()
    {
        Assert.AreEqual("Value is 00005", PaddedNumbersTask.Solution(5));
    }
}