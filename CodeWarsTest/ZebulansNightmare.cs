using CodeWars7kyu;

namespace CodeWarsTest;

public class ZebulansNightmare
{
    [Test]
    public void ZebulansNightmareTest()
    {
        Assert.AreEqual("camelCase", ZebulanNightmareTask.ZebulansNightmare("camel_case"));
        Assert.AreEqual("markAsIssue", ZebulanNightmareTask.ZebulansNightmare("mark_as_issue"));
        Assert.AreEqual("copyPastePep8", ZebulanNightmareTask.ZebulansNightmare("copy_paste_pep8"));
        Assert.AreEqual("gotoNextKata", ZebulanNightmareTask.ZebulansNightmare("goto_next_kata"));
        Assert.AreEqual("repeat", ZebulanNightmareTask.ZebulansNightmare("repeat"));
        Assert.AreEqual("trollingIsFun", ZebulanNightmareTask.ZebulansNightmare("trolling_is_fun"));
        Assert.AreEqual("why", ZebulanNightmareTask.ZebulansNightmare("why"));
        Assert.AreEqual("123AbcDef", ZebulanNightmareTask.ZebulansNightmare("123_abc_def"));
    }
}