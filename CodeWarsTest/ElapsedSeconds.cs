using CodeWars7kyu;

namespace CodeWarsTest;

public class ElapsedSeconds
{
    [Test]
    public void ElapsedSecondsTest()
    {
        var start = new DateTime(2013, 1, 1, 0, 0, 1);
        var end = new DateTime(2013, 1, 1, 0, 0, 2);
        var end2 = new DateTime(2013, 1, 1, 0, 0, 20);
        var end3 = new DateTime(2013, 1, 1, 0, 1, 20);
        Assert.AreEqual(1, ElapsedSecondsTask.ElapsedSeconds(start, end));
        Assert.AreEqual(19, ElapsedSecondsTask.ElapsedSeconds(start, end2));
        Assert.AreEqual(79, ElapsedSecondsTask.ElapsedSeconds(start, end3));
    }
}