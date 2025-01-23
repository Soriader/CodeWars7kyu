namespace CodeWarsTest;
using CodeWars7kyu;

public class YouGotChange
{
    [Test]
    public void YouGotChangeTest()
    {
        Assert.That(YouGotChangeTask.GiveChange(365), Is.EqualTo(new int[] { 0, 1, 1, 0, 1, 3 }));
        Assert.That(YouGotChangeTask.GiveChange(217), Is.EqualTo(new int[] { 2, 1, 1, 0, 0, 2 }));
    }
}