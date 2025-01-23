using CodeWars7kyu;

namespace CodeWarsTest;

public class TailSwap
{
    [Test]
    public void TailSwapTest()
    {
        Assert.AreEqual(new[] { "a:d", "c:b" }, TailSwapTask.TailSwap(new[] { "a:b", "c:d" }));
        Assert.AreEqual(new[] { "1:4", "3:2" }, TailSwapTask.TailSwap(new[] { "1:2", "3:4" }));
        Assert.AreEqual(new[] { "abc:456", "cde:123" }, TailSwapTask.TailSwap(new[] { "abc:123", "cde:456" }));
        Assert.AreEqual(new[] { "a:xyz", "777:12345" }, TailSwapTask.TailSwap(new[] { "a:12345", "777:xyz" }));
        Assert.AreEqual(new[] { "(:]", "[:)" }, TailSwapTask.TailSwap(new[] { "(:)", "[:]" }));
        Assert.AreEqual(new[] { ",:,", ",:;" }, TailSwapTask.TailSwap(new[] { ",:;", ",:," }));
    }
}