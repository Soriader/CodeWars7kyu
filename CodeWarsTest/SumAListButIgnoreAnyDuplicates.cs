using CodeWars7kyu;

namespace CodeWarsTest;

public class SumAListButIgnoreAnyDuplicates
{
    [Test]
    public void SumAListButIgnoreAnyDuplicatesTest()
    {
        Assert.AreEqual(5, SumAListButIgnoreAnyDuplicatesTask.SumNoDuplicates(new int[] { 1, 1, 2, 3 }));
        Assert.AreEqual(3, SumAListButIgnoreAnyDuplicatesTask.SumNoDuplicates(new int[] { 1, 1, 2, 2, 3 }));
    }
}