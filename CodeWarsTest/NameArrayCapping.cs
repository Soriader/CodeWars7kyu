using CodeWars7kyu;

namespace CodeWarsTest;

public class NameArrayCapping
{
    [Test]
    public void NameArrayCappingTest()
    {
        Assert.AreEqual(new string[] { "Expected" }, NameArrayCappingTask.CapMe(new string[] { "ExPeCteD" }));
    }
}