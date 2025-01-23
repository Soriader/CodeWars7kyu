using CodeWars7kyu;

namespace CodeWarsTest;

public class PatternCraftVisitor
{
    [Test]
    public void PatternCraftVisitorTask()
    {
        IVisitor bullet = new TankBullet();
        IArmoredUnit armored = new Marauder();

        armored.Accept(bullet);

        Assert.AreEqual(125 - 32, armored.Health);
    }
}