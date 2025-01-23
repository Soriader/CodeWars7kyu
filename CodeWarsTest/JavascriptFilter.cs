using CodeWars7kyu;

namespace CodeWarsTest;

public class JavascriptFilter
{
    [Test]
    public void JavascriptFilterTest()
    {
        string[][] a = { new[] { "foo_", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
        string[][] b = { new[] { "foo_", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
        Assert.That(b, Is.EquivalentTo(JavascriptFilterTask.SearchNames(a)));
    }
}