using CodeWars7kyu;

namespace CodeWarsTest;

public class ReverseWords
{
    [Test]
    public void ReverseWordsTest()
    {
        Assert.AreEqual("sihT si na !elpmaxe", ReverseWordsTask.ReverseWords("This is an example!"));
    }
}