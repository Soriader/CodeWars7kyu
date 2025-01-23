using CodeWars7kyu;

namespace CodeWarsTest;

public class TheOldSwitcheroo
{
    [Test]
    public void TheOldSwitcherooTest()
    {
        Assert.AreEqual("123", TheOldSwitcherooTask.Encode("abc"));
        Assert.AreEqual("1234", TheOldSwitcherooTask.Encode("ABCD"));
        Assert.AreEqual("2626262626", TheOldSwitcherooTask.Encode("ZzzzZ"));
        Assert.AreEqual("123-#@5", TheOldSwitcherooTask.Encode("abc-#@5"));
        Assert.AreEqual("208919 919 1 1215147 1920189147!! 161251195 [51431545] @30181853201225", TheOldSwitcherooTask.Encode("this is a long string!! Please [encode] @C0RrEctly"));
    }
}