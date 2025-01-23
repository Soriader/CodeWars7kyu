using CodeWars7kyu;

namespace CodeWarsTest;

public class OddMarchBits8Bits
{
    [Test]
    public void OddMarchBits8BitsTest()
    {
        var expected = new int[][]
        {new int[]{0, 0, 0, 0, 0, 1, 1, 1},
            new int[]{0, 0, 0, 0, 1, 1, 1, 0},
            new int[]{0, 0, 0, 1, 1, 1, 0, 0},
            new int[]{0, 0, 1, 1, 1, 0, 0, 0},
            new int[]{0, 1, 1, 1, 0, 0, 0, 0},
            new int[]{1, 1, 1, 0, 0, 0, 0, 0}};
        var actual = new OddMarchBits8BitsTask().BitMarch(3);
        Assert.That(actual, Is.EqualTo(expected));
    }
}