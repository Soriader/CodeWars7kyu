using CodeWars7kyu;

namespace CodeWarsTest;

public class GhostbustersWhitespaceRemoval
{
    [Test]
    public void GhostbustersWhitespaceRemovalTest()
    {
        Assert.AreEqual("Factory", GhostbustersWhitespaceRemovalTask.GhostBusters("Factor y"), "Nope, there may still be a ghost in the building. Try again.");
        Assert.AreEqual("Office", GhostbustersWhitespaceRemovalTask.GhostBusters("O  f fi ce"), "Nope, there may still be a ghost in the building. Try again.");
        Assert.AreEqual("You just wanted my autograph didn't you?", GhostbustersWhitespaceRemovalTask.GhostBusters("BusStation"), "Nope, as there were no ghosts in the BusStation you need to return a witty retort.");
    }
}