using CodeWars7kyu;

namespace CodeWarsTest;

public class Quarks
{
    [Test]
    public void QuarksTest()
    {
        QuarksTask q1 = new QuarksTask("red", "up");
        QuarksTask q2 = new QuarksTask("blue", "strange");
        Assert.AreEqual("red", q1.Color);
        Assert.AreEqual("strange", q2.Flavor);
        Assert.AreEqual(1 / 3d, q2.BaryonNumber);

        q1.Interact(q2);
        Assert.AreEqual("blue", q1.Color);
    }
}