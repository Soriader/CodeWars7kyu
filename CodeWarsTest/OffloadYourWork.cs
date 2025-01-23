using CodeWars7kyu;

namespace CodeWarsTest;

public class OffloadYourWork
{
    [Test]
    public void OffloadYourWorkTest()
    {
        var arr = new int[][] { new[] { 1, 0 } };
        Assert.That(OffloadYourWorkTask.WorkNeeded(60, arr), Is.EqualTo("Easy Money!"));
    }
}