using CodeWars7kyu;

namespace CodeWarsTest;

public class JumpingNumber
{
    [Test]
    public void JumpingNumberTest()
    {
        Assert.That(JumpingNumberTask.JumpingNumber(00000079), Is.EqualTo("Not!!"));
        Assert.That(JumpingNumberTask.JumpingNumber(98789876), Is.EqualTo("Jumping!!"));
    }
}