using CodeWars7kyu;

namespace CodeWarsTest;

public class ResponsibleDrinking
{
    [Test]
    public void ResponsibleDrinkingTest()
    {
        ResponsibleDrinkingTask drinkin = new ResponsibleDrinkingTask();
        string expected = "10 glasses of water";
        string actual = drinkin.Hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
        Assert.AreEqual(expected, actual);

        string expected2 = "1 glass of water";
        string actual2 = drinkin.Hydrate("1 beer");
        Assert.AreEqual(expected, actual);
    }
}