using CodeWars7kyu;

namespace CodeWarsTest;

public class Incrementer
{
    [Test]
    public void IncrementerTest()
    {
        Assert.AreEqual(new int[] { 2, 4, 6 }, IncrementerTask.Incrementer(new int[] { 1, 2, 3 }));
        Assert.AreEqual(new int[0], IncrementerTask.Incrementer(new int[0]));
        Assert.AreEqual(new int[] { 5, 8, 0, 5, 8 }, IncrementerTask.Incrementer(new int[] { 4, 6, 7, 1, 3 }));
        Assert.AreEqual(new int[] { 2, 4, 6, 8, 0, 2, 4, 6, 8, 9, 0, 1, 2, 2 }, IncrementerTask.Incrementer(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 8 }));
    }
}