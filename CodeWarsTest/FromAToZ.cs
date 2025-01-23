using CodeWars7kyu;

namespace CodeWarsTest;

public class FromAToZ
{
    [Test]
    public void FromAToZTest()
    {
        Assert.AreEqual("J", FromAToZTask.GimmeTheLetters("J-J"));
        Assert.AreEqual("Z", FromAToZTask.GimmeTheLetters("Z-Z"));
        Assert.AreEqual("a", FromAToZTask.GimmeTheLetters("a-a"));
        Assert.AreEqual("ab", FromAToZTask.GimmeTheLetters("a-b"));
        Assert.AreEqual("yz", FromAToZTask.GimmeTheLetters("y-z"));
        Assert.AreEqual("HI", FromAToZTask.GimmeTheLetters("H-I"));
        Assert.AreEqual("QRSTUVWXYZ", FromAToZTask.GimmeTheLetters("Q-Z"));
        Assert.AreEqual("FGHIJKLMNO", FromAToZTask.GimmeTheLetters("F-O"));
        Assert.AreEqual("CDEFGHIJKLMNOPQR", FromAToZTask.GimmeTheLetters("C-R"));
        Assert.AreEqual("hijklmno", FromAToZTask.GimmeTheLetters("h-o"));
        Assert.AreEqual("efghijk", FromAToZTask.GimmeTheLetters("e-k"));
        Assert.AreEqual("abcdefghijklmnopq", FromAToZTask.GimmeTheLetters("a-q"));
        Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", FromAToZTask.GimmeTheLetters("a-z"));
        Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", FromAToZTask.GimmeTheLetters("A-Z"));
    }
}