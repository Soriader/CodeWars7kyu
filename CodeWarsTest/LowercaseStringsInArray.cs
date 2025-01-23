using CodeWars7kyu;

namespace CodeWarsTest;

public class LowercaseStringsInArray
{
    [Test]
    public void LowercaseStringsInArrayTest()
    {
        Assert.AreEqual(new object[] { "red", "green" }, LowercaseStringsInArrayTask.ArrayLowerCase(new object[] { "Red", "Green" }));
    }
}