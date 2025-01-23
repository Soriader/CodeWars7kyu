using CodeWars7kyu;

namespace CodeWarsTest;

public class FunctionalAddition
{
    [Test]
    public void FunctionalAdditionTest()
    {
        Assert.AreEqual(4, FunctionalAdditionTask.Add(1)(3));
    }
}