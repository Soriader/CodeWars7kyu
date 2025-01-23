using CodeWars7kyu;

namespace CodeWarsTest;

public class SumofNumbersFrom0ToN
{
    [Test]
    public void SumofNumbersFrom0ToNTest()
    {
        Assert.AreEqual("0+1+2+3+4+5+6 = 21", SumofNumbersFrom0ToNTask.ShowSequence(6));
        Assert.AreEqual("-5<0", SumofNumbersFrom0ToNTask.ShowSequence(-5));
        Assert.AreEqual("0=0", SumofNumbersFrom0ToNTask.ShowSequence(0));
    }
}