using CodeWars7kyu;

namespace CodeWarsTest;

public class BuildingStringsFromAHash
{
    [Test]
    public void BuildingStringsFromAHashTest()
    {
        Assert.AreEqual("a = 1,b = 2", BuildingStringsFromAHashTask.StringifyDict(new Dictionary<char, int> { { 'a', 1 }, { 'b', 2 } }));
        Assert.AreEqual("b = 1,c = 2,e = 3", BuildingStringsFromAHashTask.StringifyDict(new Dictionary<char, int> { { 'b', 1 }, { 'c', 2 }, { 'e', 3 } }));
        Assert.AreEqual("", BuildingStringsFromAHashTask.StringifyDict(new Dictionary<char, int>()));
    }
}