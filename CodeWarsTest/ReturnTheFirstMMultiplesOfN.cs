using CodeWars7kyu;

namespace CodeWarsTest;

public class ReturnTheFirstMMultiplesOfN
{
    [Test]
    public void ReturnTheFirstMMultiplesOfNTest()
    {
        Assert.AreEqual(new double[] { 5, 10, 15 }, ReturnTheFirstMMultiplesOfNTask.Multiples(3, 5));
    }
}