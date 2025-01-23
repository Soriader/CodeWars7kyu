using CodeWars7kyu;

namespace CodeWarsTest;

public class IsTriangle
{
    [Test]
    public void IsTriangleTest()
    {
        Assert.IsTrue(IsTriangleTask.IsTriangle(5, 7, 10));
    }
}