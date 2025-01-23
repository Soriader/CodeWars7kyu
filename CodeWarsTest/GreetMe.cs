using CodeWars7kyu;

namespace CodeWarsTest;

public class GreetMe
{
    [Test]
    public void GreetMeTest()
    {
        Assert.That(GreetMeTask.Greet("riley"), Is.EqualTo("Hello Riley!"));
        Assert.That(GreetMeTask.Greet("DaRO"), Is.EqualTo("Hello Daro!"));
    }
}