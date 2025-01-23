using CodeWars7kyu;

namespace CodeWarsTest;

public class IsIsogram
{
    [Test]
    public void IsIsogramTest()
    {
        Assert.AreEqual(expected: true, actual: IsIsogramTask.IsIsogram("Dermatoglyphics"));
        Assert.AreEqual(expected: true, actual: IsIsogramTask.IsIsogram("isogram"));
        Assert.AreEqual(expected: false, actual: IsIsogramTask.IsIsogram("moose"));
        Assert.AreEqual(expected: false, actual: IsIsogramTask.IsIsogram("isIsogram"));
    }
}