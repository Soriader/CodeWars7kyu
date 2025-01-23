using CodeWars7kyu;

namespace CodeWarsTest;

public class RockPaperScissorsLizardSpock
{
    [Test]
    public void RockPaperScissorsLizardSpockTest()
    {
        Assert.AreEqual(RockPaperScissorsLizardSpockTask.Ordering.EQ, RockPaperScissorsLizardSpockTask.Rpsls(RockPaperScissorsLizardSpockTask.Value.Rock, RockPaperScissorsLizardSpockTask.Value.Rock));
        Assert.AreEqual(RockPaperScissorsLizardSpockTask.Ordering.LT, RockPaperScissorsLizardSpockTask.Rpsls(RockPaperScissorsLizardSpockTask.Value.Paper, RockPaperScissorsLizardSpockTask.Value.Scissors));
    }
}