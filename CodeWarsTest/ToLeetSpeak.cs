using CodeWars7kyu;

namespace CodeWarsTest;

public class ToLeetSpeak
{
    [Test]
    public void ToLeetSpeakTest()
    {
        Assert.AreEqual("1337", ToLeetSpeakTask.ToLeetSpeak("LEET"));
        Assert.AreEqual("(0D3W@R$", ToLeetSpeakTask.ToLeetSpeak("CODEWARS"));
        Assert.AreEqual("#3110 W0R1D", ToLeetSpeakTask.ToLeetSpeak("HELLO WORLD"));
        Assert.AreEqual("10R3M !P$UM D010R $!7 @M37", ToLeetSpeakTask.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"));
        Assert.AreEqual("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06", ToLeetSpeakTask.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
    }
}