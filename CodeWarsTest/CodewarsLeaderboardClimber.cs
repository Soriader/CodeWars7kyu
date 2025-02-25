namespace CodeWarsTest;

using CodeWars7kyu;

public class CodewarsLeaderboardClimber
{
    [Test]
    public void CodewarsLeaderboardClimberTest()
    {
        Assert.That(CodewarsLeaderboardClimberTask.LeaderB("g964", 36097, 20000), Is.EqualTo("To beat g964's score, I must complete 5365 Beta kata and 2 8kyu kata. Dammit!"));
        Assert.That(CodewarsLeaderboardClimberTask.LeaderB("GiacomoSorbi", 23914, 23867), Is.EqualTo("To beat GiacomoSorbi's score, I must complete 15 Beta kata and 2 8kyu kata."));
        Assert.That(CodewarsLeaderboardClimberTask.LeaderB("ZozoFouchtra", 15991, 12000), Is.EqualTo("To beat ZozoFouchtra's score, I must complete 1330 Beta kata and 1 8kyu kata. Dammit!")); 
    }
}