using CodeWars7kyu;

namespace CodeWarsTest;

public class LongestVowelChain
{
    [Test]
    public void LongestVowelChainTest()
    {
        Assert.AreEqual(2, LongestVowelChainTask.Solve("codewarriors"));
        Assert.AreEqual(3, LongestVowelChainTask.Solve("suoidea"));
        Assert.AreEqual(3, LongestVowelChainTask.Solve("ultrarevolutionariees"));
        Assert.AreEqual(1, LongestVowelChainTask.Solve("strengthlessnesses"));
        Assert.AreEqual(2, LongestVowelChainTask.Solve("cuboideonavicuare"));
        Assert.AreEqual(5, LongestVowelChainTask.Solve("chrononhotonthuooaos"));
        Assert.AreEqual(8, LongestVowelChainTask.Solve("iiihoovaeaaaoougjyaw"));
    }
}