using CodeWars7kyu;

namespace CodeWarsTest;

public class FindFactorsOfANumber
{
    [Test]
    public void FindFactorsOfANumberTest()
    {
        Assert.AreEqual(new int[] { 54, 27, 18, 9, 6, 3, 2, 1 }, FindFactorsOfANumberTask.Factors(54));
        Assert.AreEqual(new int[] { 9, 3, 1 }, FindFactorsOfANumberTask.Factors(9));
    }
}