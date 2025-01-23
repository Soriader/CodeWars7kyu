using CodeWars7kyu;

namespace CodeWarsTest;

public class FloatPrecision
{
    [Test]
    public void FloatPrecisionTest()
    {
        Assert.AreEqual(2.34, FloatPrecisionTask.Round(2.34));
        Assert.AreEqual(5.68, FloatPrecisionTask.Round(5.678));
    }
}