using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfTriangularNumbers
{
    [Test]
    public void SumOfTriangularNumbersTest()
    {
        Assert.AreEqual(56, SumOfTriangularNumbersTask.SumTriangularNumbers(6));
        Assert.AreEqual(7140, SumOfTriangularNumbersTask.SumTriangularNumbers(34));
        Assert.AreEqual(0, SumOfTriangularNumbersTask.SumTriangularNumbers(-291));
        Assert.AreEqual(140205240, SumOfTriangularNumbersTask.SumTriangularNumbers(943));
        Assert.AreEqual(0, SumOfTriangularNumbersTask.SumTriangularNumbers(-971));
    }
}