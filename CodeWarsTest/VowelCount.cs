using CodeWars7kyu;

namespace CodeWarsTest;

public class VowelCount
{
    [Test]
    public void VowelCountTest()
    {
        Assert.AreEqual(5, VowelCountTask.GetVowelCount("abracadabra"));
    }
}