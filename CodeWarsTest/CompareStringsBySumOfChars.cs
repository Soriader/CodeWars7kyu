using CodeWars7kyu;

namespace CodeWarsTest;

public class CompareStringsBySumOfChars
{
    [Test]
    public void CompareStringsBySumOfCharsTest()
    {
        Assert.AreEqual(true, CompareStringsBySumOfCharsTask.Compare("AD", "BC"));
        Assert.AreEqual(false, CompareStringsBySumOfCharsTask.Compare("AD", "DD"));

    }
}