using CodeWars7kyu;

namespace CodeWarsTest;

public class DryingPotatoes
{
    [Test]
    public void DryingPotatoesTest()
    {
        Assert.AreEqual(114, DryingPotatoesTask.Potatoes(82, 127, 80));
        Assert.AreEqual(100, DryingPotatoesTask.Potatoes(93, 129, 91));

    }
}