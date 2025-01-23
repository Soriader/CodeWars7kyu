using CodeWars7kyu;

namespace CodeWarsTest;

public class CleanUp
{
    [Test]
    public void CleanUpTest()
    {
        Assert.AreEqual("Clean", CleanUpTask.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 2, 2));
        Assert.AreEqual("Cr@p", CleanUpTask.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 1, 1));
        Assert.AreEqual("Dog!!", CleanUpTask.Crap(new char[,] { { '_', '_' }, { '_', '@' }, { 'D', '_' } }, 2, 2));
    }
}