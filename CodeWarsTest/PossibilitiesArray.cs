using CodeWars7kyu;

namespace CodeWarsTest;

public class PossibilitiesArray
{
    [Test]
    public void PossibilitiesArrayTest()
    {
        Assert.AreEqual(true, PossibilitiesArrayTask.IsAllPossibilities(new int[] { 0, 1, 2, 3 }));
        Assert.AreEqual(false, PossibilitiesArrayTask.IsAllPossibilities(new int[] { 1, 2, 3, 4 }));
    }
}