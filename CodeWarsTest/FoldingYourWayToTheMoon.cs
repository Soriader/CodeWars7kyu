using CodeWars7kyu;

namespace CodeWarsTest;

public class FoldingYourWayToTheMoon
{
    [Test]
    public void FoldingYourWayToTheMoonTest()
    {
        Assert.AreEqual(42, FoldingYourWayToTheMoonTask.FoldTo(384000000));
    }
}