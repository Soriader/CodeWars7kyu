using CodeWars7kyu;

namespace CodeWarsTest;

public class DifferenceOfSquares
{
    [Test]
    public void DifferenceOfSquaresTest()
    {
        Assert.AreEqual(170, DifferenceOfSquaresTask.DifferenceOfSquares(5));
        Assert.AreEqual(2640, DifferenceOfSquaresTask.DifferenceOfSquares(10));
        Assert.AreEqual(25164150, DifferenceOfSquaresTask.DifferenceOfSquares(100));
    }
}