using CodeWars7kyu;

namespace CodeWarsTest;

public class WeirdWords
{
    [Test]
    public void WeirdWordsTest()
    {
        Assert.AreEqual("Nz Obnf Jt App", WeirdWordsTask.NextLetter("My Name Is Zoo"));
        Assert.AreEqual("Xibu jt zpvs obnf", WeirdWordsTask.NextLetter("What is your name"));
        Assert.AreEqual("aPp", WeirdWordsTask.NextLetter("zOo"));
    }
}