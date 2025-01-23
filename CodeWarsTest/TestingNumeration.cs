using CodeWars7kyu;

namespace CodeWarsTest;

public class TestingNumeration
{
    [Test]
    public void TestingNumerationTest()
    {
        Assert.AreEqual(new List<string>(), TestingNumerationTask.Number(new List<string>()));
        Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, TestingNumerationTask.Number(new List<string> { "a", "b", "c" }));
        Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, TestingNumerationTask.Number(new List<string> { "", "", "", "", "" }));
    }
}