namespace CodeWarsTest;

using CodeWars7kyu;

public class HighestPowerOfTwo
{
    [Test]
    public void HighestPowerOfTwoTest()
    {
        Assert.That(HighestPowerOfTwoTask.Solution(123), Is.EqualTo(1));
        Assert.That(HighestPowerOfTwoTask.Solution(64), Is.EqualTo(64));
        Assert.That(HighestPowerOfTwoTask.Solution(132232), Is.EqualTo(8));
        Assert.That(HighestPowerOfTwoTask.Solution(192), Is.EqualTo(64));
    }
}