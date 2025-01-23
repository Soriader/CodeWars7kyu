using CodeWars7kyu;

namespace CodeWarsTest;

public class EverythingIsEven
{
    [Test]
    public void EverythingIsEvenTest()
    {
        Assert.AreEqual(2, EverythingIsEvenTask.EnsureEven(1));
        Assert.AreEqual(2, EverythingIsEvenTask.EnsureEven(1.356));
    }
}