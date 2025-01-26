using CodeWars7kyu;

namespace CodeWarsTest;

public class SimpleArrayProduct
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int [] { 1, 2 }, new int [] { 3, 4 } }), Is.EqualTo(8));
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int [] { 10, -15 }, new int [] { -1, -3 } }), Is.EqualTo(45));
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int [] { -1, 2, -3, 4 }, new int [] { 1, -2, 3, -4 } }), Is.EqualTo(12));
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int [] { -11, -6 }, new int[] { -20, -20 }, new int[] { 18, -4 }, new int[] { -20, 1 } }), Is.EqualTo(17600));
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int[] { 14, 2 }, new int[] { 0, -16 }, new int[] { -12, -16 } }), Is.EqualTo(3584));
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int [] { -3, -4 }, new int [] { 1, 2, -3 } }), Is.EqualTo(12));
        Assert.That(SimpleArrayProductTask.SimpleArray(new int [][] { new int [] { -2, -15, -12, -8, -16 }, new int [] { -4, -15, -7 }, new int [] { -10, -5 } }), Is.EqualTo(-40));
    }
}