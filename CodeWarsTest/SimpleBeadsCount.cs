using CodeWars7kyu;

namespace CodeWarsTest;

public class SimpleBeadsCount
{
    [Test]
    public void SimpleBeadsCountTest()
    {
        Assert.That(SimpleBeadsCountTask.CountRedBeads(0), Is.EqualTo(0));
        Assert.That(SimpleBeadsCountTask.CountRedBeads(1), Is.EqualTo(0));
        Assert.That(SimpleBeadsCountTask.CountRedBeads(3), Is.EqualTo(4));
        Assert.That(SimpleBeadsCountTask.CountRedBeads(5), Is.EqualTo(8));
    }
}