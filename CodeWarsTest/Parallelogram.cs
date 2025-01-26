using CodeWars7kyu;

namespace CodeWarsTest;

public class Parallelogram
{
    [Test]
    public void ParallelogramTest()
    {
        Assert.That(ParallelogramTask.Pattern(3), Is.EqualTo("  123\n 123 \n123  "));
        Assert.That(ParallelogramTask.Pattern(5), Is.EqualTo("    12345\n   12345 \n  12345  \n 12345   \n12345    "));
        Assert.That(ParallelogramTask.Pattern(8), Is.EqualTo("       12345678\n      12345678 \n     12345678  \n    12345678   \n   12345678    \n  12345678     \n 12345678      \n12345678       "));
    }
}