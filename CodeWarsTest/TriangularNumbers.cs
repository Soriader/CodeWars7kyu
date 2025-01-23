using CodeWars7kyu;

namespace CodeWarsTest;

public class TriangularNumbers
{
    [Test]
    public void TriangularNumbersTest()
    {
        Assert.AreEqual(true, TriangularNumbersTask.IsTriangular(6));
    }
}