namespace CodeWarsTest;

using CodeWars7kyu;

public class Rounding
{
    [Test]
    public void RoundingTest()
    {
        Assert.That(RoundingTask.Rounding(20,3), Is.EqualTo(21));
        Assert.That(RoundingTask.Rounding(19,3), Is.EqualTo(18));
        Assert.That(RoundingTask.Rounding(1,10), Is.EqualTo(0));
        Assert.That(RoundingTask.Rounding(50,100), Is.EqualTo(50));
        Assert.That(RoundingTask.Rounding(123,456), Is.EqualTo(0));
    }
}