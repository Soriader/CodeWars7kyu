using CodeWars7kyu;

namespace CodeWarsTest;

public class StringReverseSlicing101
{
    [Test]
    public void StringReverseSlicing101Test()
    {
        Assert.AreEqual(new string[] { "321", "21", "1" }, StringReverseSlicing101Task.ReverseSlice("123"));
        Assert.AreEqual(new string[] { "edcba", "dcba", "cba", "ba", "a" }, StringReverseSlicing101Task.ReverseSlice("abcde"));
    }
}