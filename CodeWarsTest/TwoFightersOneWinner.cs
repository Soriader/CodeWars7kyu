using CodeWars7kyu;

namespace CodeWarsTest;

public class TwoFightersOneWinner
{
    [Test]
    public void TwoFightersOneWinnerTest()
    {
        Assert.AreEqual("Lew", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Lew", 10, 2), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Lew"));
        Assert.AreEqual("Harry", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Lew", 10, 2), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harry"));
        Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harry"));
        Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harald"));
        Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Jerry", 30, 3), new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), "Jerry"));
        Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Jerry", 30, 3), new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), "Harald"));

    }
}