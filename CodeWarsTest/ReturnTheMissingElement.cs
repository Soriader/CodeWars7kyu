using CodeWars7kyu;

namespace CodeWarsTest;

public class ReturnTheMissingElement
{
    [Test]
    public void ReturnTheMissingElementTest()
    {
        Assert.AreEqual(8, ReturnTheMissingElementTask.GetMissingElement(new int[9] { 0, 5, 1, 3, 2, 9, 7, 6, 4 }));
        Assert.AreEqual(3, ReturnTheMissingElementTask.GetMissingElement(new int[9] { 9, 2, 4, 5, 7, 0, 8, 6, 1 }));
    }
}