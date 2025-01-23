using CodeWars7kyu;

namespace CodeWarsTest;

public class ReturnStringOfFirstCharacters
{
    [Test]
    public static void ReturnStringOfFirstCharactersTest()
    {
        Assert.AreEqual("cia", ReturnStringOfFirstCharactersTask.MakeString("coding is awesome"));
    }
}