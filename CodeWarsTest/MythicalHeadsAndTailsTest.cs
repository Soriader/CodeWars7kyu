namespace CodeWarsTest;

using CodeWars7kyu;

public class MythicalHeadsAndTailsTest
{
    [Test]
    public void MythicalHeadsAndTails()
    {
        Assert.That(MythicalHeadsAndTailsTask.Beasts(123, 39), Is.EqualTo(new int[] { 24, 15 }));
        Assert.That(MythicalHeadsAndTailsTask.Beasts(371, 88), Is.EqualTo(new int[] { 23, 65 }));
        Assert.That(MythicalHeadsAndTailsTask.Beasts(24, 12), Is.EqualTo(new int[] { 12, 0 }));
        Assert.That(MythicalHeadsAndTailsTask.Beasts(113, 37), Is.EqualTo(new int[] { 24, 13 }));
        Assert.That(MythicalHeadsAndTailsTask.Beasts(635, 181), Is.EqualTo(new int[] { 90, 91 }));
    }
}