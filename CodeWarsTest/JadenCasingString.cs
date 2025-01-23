using CodeWars7kyu;

namespace CodeWarsTest;

public class JadenCasingString
{
    [Test]
    public void JadenCasingStringTest()
    {
        Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", JadenCasingStringTask.ToJadenCase("How can mirrors be real if our eyes aren't real"));
    }
}