using CodeWars7kyu;

namespace CodeWarsTest;

public class OddOrEven
{
    [Test]
    public void OddOrEvenTest()
    {
        Assert.AreEqual("even", OddOrEvenTask.OddOrEven(new int[] { 0 }));
        Assert.AreEqual("odd", OddOrEvenTask.OddOrEven(new int[] { 1 }));
        Assert.AreEqual("even", OddOrEvenTask.OddOrEven(new int[] { }));
    }
}