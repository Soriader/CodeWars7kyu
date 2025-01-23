using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfIntegersInString
{
    [Test]
    public void SumOfIntegersInStringTest()
    {
        Assert.AreEqual(16, SumOfIntegersInStringTask.SumOfIntegersInString("12.4"));
        Assert.AreEqual(3, SumOfIntegersInStringTask.SumOfIntegersInString("h3ll0w0rld"));
        Assert.AreEqual(1, SumOfIntegersInStringTask.SumOfIntegersInString("Our company made approximately 1 million in gross revenue last quarter."));
        Assert.AreEqual(18, SumOfIntegersInStringTask.SumOfIntegersInString("C4t5 are 4m4z1ng."));
        Assert.AreEqual(3635, SumOfIntegersInStringTask.SumOfIntegersInString("The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog"));
    }
}