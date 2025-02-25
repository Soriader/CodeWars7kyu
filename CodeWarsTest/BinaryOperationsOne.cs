namespace CodeWarsTest;

using CodeWars7kyu;

public class BinaryOperationsOne
{
    [Test]
    public void BinaryOperationsOneTest()
    {
        Assert.That(BinaryOperationsTask.FlipBit(15, 4), Is.EqualTo(7));
        Assert.That(BinaryOperationsTask.FlipBit(15, 1), Is.EqualTo(14));
        Assert.That(BinaryOperationsTask.FlipBit(0, 1), Is.EqualTo(1));
    }

}