using CodeWars7kyu;

namespace CodeWarsTest;

public class PreviousMultipleOfThree
{
    [Test]
    public static void PreviousMultipleOfThreeTest() 
    { 
        Assert.AreEqual(null, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(1));
        Assert.AreEqual(null, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(25));
        Assert.AreEqual(36, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(36));
        Assert.AreEqual(12, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(1244));
        Assert.AreEqual(9, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(952406));
    }
}