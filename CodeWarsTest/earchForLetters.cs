using CodeWars7kyu;

namespace CodeWarsTest;

public class earchForLetters
{
    [Test]
    public void SearchForLettersTest() 
    {
        Assert.AreEqual("11000000000000000000000001", SearchForLettersTask.Change("a **&  bZ"));
        Assert.AreEqual("10000010000000000101000000", SearchForLettersTask.Change("!!a$%&RgTT"));

    }
}