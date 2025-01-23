namespace CodeWarsTest;

using CodeWars7kyu;

public class TheRobberLanguageTest
{
    [Test]
    public void TheRobberLanguage()
    {
        Assert.AreEqual("hohelollolo wowororloldod", TheRobberLanguageTask.RobberEncode("hello world"));
        Assert.AreEqual("cocododinongog isos fofunon", TheRobberLanguageTask.RobberEncode("coding is fun"));
        Assert.AreEqual("fofolollolowow tothohe wowhohitote rorabobbobitot", TheRobberLanguageTask.RobberEncode("follow the white rabbit"));
        Assert.AreEqual("SOS.O.SOS", TheRobberLanguageTask.RobberEncode("S.O.S"));
    }
}