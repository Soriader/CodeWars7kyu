using CodeWars7kyu;

namespace CodeWarsTest;

public class SayHello
{
    [Test]
    public void SayHelloTest()
    {
        Assert.AreEqual(SayHelloTask.Greet("Niks"), "hello Niks!");
        Assert.AreEqual(SayHelloTask.Greet(""), null);
        Assert.AreEqual(SayHelloTask.Greet(null), null);
    }
}