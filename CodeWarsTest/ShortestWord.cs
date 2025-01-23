using CodeWars7kyu;

namespace CodeWarsTest;

public class ShortestWord
{
    [Test]
    public void ShortestWordTest()
    {
        Assert.AreEqual(3, ShortestWordTask.FindShort("bitcoin take over the world maybe who knows perhaps"));
        Assert.AreEqual(3, ShortestWordTask.FindShort("turns out random test cases are easier than writing out basic ones"));
        Assert.AreEqual(2, ShortestWordTask.FindShort("Let's travel abroad shall we"));
    }
}