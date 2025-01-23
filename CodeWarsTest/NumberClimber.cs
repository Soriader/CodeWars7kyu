using CodeWars7kyu;

namespace CodeWarsTest;

public class NumberClimber
{
    [Test]
    public void NumberClimberTest()
    {
        Assert.AreEqual(string.Join(",", new int[] { 1 }), string.Join(",", NumberClimberTask.Climb(1)));
        Assert.AreEqual(string.Join(",", new int[] { 1, 2, 5, 10 }), string.Join(",", NumberClimberTask.Climb(10)));
        Assert.AreEqual(string.Join(",", new int[] { 1, 3, 6, 13 }), string.Join(",", NumberClimberTask.Climb(13)));
    }
}