using CodeWars7kyu;

namespace CodeWarsTest;

public class Ch4113ng3
{
    [Test]
    public void Ch4113ng3Test()
    {
        Assert.AreEqual("S3v3n", Ch4113ng3Task.Nerdify("Seven"));
        Assert.AreEqual("Fund4m3nt41s", Ch4113ng3Task.Nerdify("Fund4m3nt41s"));
        Assert.AreEqual("Los 4ng313s", Ch4113ng3Task.Nerdify("Los Angeles"));

    }
}