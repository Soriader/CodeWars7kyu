using CodeWars7kyu;

namespace CodeWarsTest;

public class MakingCopies
{
    [Test]
    public void MakingCopiesTest()
    {
        Assert.AreEqual(new int[] { 1, 2, 3, 4 }.ToList(), MakingCopiesTask.Copy(new int[] { 1, 2, 3, 4 }.ToList()));

    }
}