using CodeWars7kyu;

namespace CodeWarsTest;

public class IndexedCapitalization
{
    [Test]
    public void IndexedCapitalizationTest()
    {
        Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 2, 5 }));
        Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 2, 5, 100 }));
        Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 100, 2, 5 }));
        Assert.AreEqual("cOdEwArs", IndexedCapitalizationTask.Capitalize("codewars", new List<int> { 1, 3, 5, 50 }));
        Assert.AreEqual("abRacaDabRA", IndexedCapitalizationTask.Capitalize("abracadabra", new List<int> { 2, 6, 9, 10 }));
        Assert.AreEqual("codewArriors", IndexedCapitalizationTask.Capitalize("codewarriors", new List<int> { 5 }));
        Assert.AreEqual("Indexinglessons", IndexedCapitalizationTask.Capitalize("indexinglessons", new List<int> { 0 }));
    }
}