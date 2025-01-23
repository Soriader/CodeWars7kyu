using CodeWars7kyu;

namespace CodeWarsTest;

public class TwoToOneSortedString
{
    [Test]
    public static void TwoToOneSortedStringTest()
    {
        Assert.AreEqual("aehrsty", TwoToOneSortedStringTask.Longest("aretheyhere", "yestheyarehere"));
        Assert.AreEqual("abcdefghilnoprstu", TwoToOneSortedStringTask.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
        Assert.AreEqual("acefghilmnoprstuy", TwoToOneSortedStringTask.Longest("inmanylanguages", "theresapairoffunctions"));
    }
}