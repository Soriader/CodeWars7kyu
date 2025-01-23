using CodeWars7kyu;

namespace CodeWarsTest;

public class SimpleStringCharacters
{
    [Test]
    public void SimpleStringCharactersTest()
    {
        Assert.AreEqual(new int[] { 1, 18, 3, 2 }, SimpleStringCharactersTask.Solve("Codewars@codewars123.com"));
        Assert.AreEqual(new int[] { 7, 6, 3, 2 }, SimpleStringCharactersTask.Solve("bgA5<1d-tOwUZTS8yQ"));
        Assert.AreEqual(new int[] { 9, 9, 6, 9 }, SimpleStringCharactersTask.Solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"));
        Assert.AreEqual(new int[] { 15, 8, 6, 9 }, SimpleStringCharactersTask.Solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"));
    }
}