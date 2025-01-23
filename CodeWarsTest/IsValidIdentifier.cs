using CodeWars7kyu;

namespace CodeWarsTest;

public class IsValidIdentifier
{
    [Test]
    public void IsValidIdentifierTest()
    {
        Assert.IsFalse(IsValidIdentifierTask.IsValid("1i"));
        Assert.IsTrue(IsValidIdentifierTask.IsValid("i1"));
    }
}