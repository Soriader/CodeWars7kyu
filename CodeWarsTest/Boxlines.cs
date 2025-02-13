namespace CodeWarsTest;

using CodeWars7kyu;

public class Boxlines
{
    private static void Act(ushort x, ushort y, ushort z, ulong expected)
    {
        var msg = $"Invalid answer for x: {x}, y: {y}, z: {z}";
        var actual = BoxlinesTask.F(x, y, z);
        Assert.That(actual, Is.EqualTo(expected), msg);
    }
      
    [TestCase(2, 1, 1, 20UL)]
    [TestCase(1, 2, 3, 46UL)]
    [TestCase(2, 2, 2, 54UL)]
    public void BoxlinesTest(int x, int y, int z, ulong expected)
    {
        Act((ushort)x, (ushort)y, (ushort)z, expected);
    }
}
