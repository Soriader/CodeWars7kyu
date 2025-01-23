using CodeWars7kyu;

namespace CodeWarsTest;

public class IsNDivisible
{
    [Test]
    public void IsNDivisibleTest()
    {
        Assert.AreEqual(false, IsNDivisibleTask.IsDivisible(3, 3, 4));
        Assert.AreEqual(true, IsNDivisibleTask.IsDivisible(12, 3, 4));

    }
}