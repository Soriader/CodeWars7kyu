using CodeWars7kyu;

namespace CodeWarsTest;

public class SquareEveryDigit
{
    [Test]
    public void SquareEveryDigitTest()
    {
        Assert.AreEqual(811181, SquareEveryDigitTask.SquareDigits(9119));
        Assert.AreEqual(0, SquareEveryDigitTask.SquareDigits(0));
    }
}