using CodeWars7kyu;

namespace CodeWarsTest;

public class uzukiNeedsHelpLiningUp
{
    [Test]
    public void SuzukiNeedsHelpLiningUpTest()
    {
        string students = "Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi";
        string[] expected = { "Takehiko", "Takayuki", "Takahiro", "Takeshi", "Takeshi", "Takashi", "Tadashi", "Takeo", "Takao" };
        Assert.AreEqual(expected, SuzukiNeedsHelpLiningUpTask.LineupStudents(students));
    }
}