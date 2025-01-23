using CodeWars7kyu;

namespace CodeWarsTest;

public class NthRootOfANumber
{
    [Test]
    public static void NthRootOfANumberTest()
    {
        double actual1 = NthRootOfANumberTask.FindRoot(4, 2);
        double actual2 = NthRootOfANumberTask.FindRoot(8, 3);
        Assert.AreEqual(2, actual2, 1e-9);
        Assert.AreEqual(2, actual1, 1e-9);
    }
}