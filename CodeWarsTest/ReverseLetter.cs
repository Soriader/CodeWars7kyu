using CodeWars7kyu;

namespace CodeWarsTest;

public class ReverseLetter
{
    [Test]
    public void ReverseLetterTest()
    {
        Assert.AreEqual("nahsirk", ReverseLetterTask.ReverseLetter("krishan"));

        Assert.AreEqual("nortlu", ReverseLetterTask.ReverseLetter("ultr53o?n"));

        Assert.AreEqual("cba", ReverseLetterTask.ReverseLetter("ab23c"));

        Assert.AreEqual("nahsirk", ReverseLetterTask.ReverseLetter("krish21an"));

    }
}