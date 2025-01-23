using CodeWars7kyu;

namespace CodeWarsTest;

public class DigitsExplosion
{
    [Test]
    public void DigitsExplosionTest()
    {
        Assert.AreEqual("333122", DigitsExplosionTask.Explode("312"));
        Assert.AreEqual("12222666666999999999", DigitsExplosionTask.Explode("102269"));
    }
}