using CodeWars7kyu;

namespace CodeWarsTest;

public class AllInclusive
{
    [Test]
    public static void AllInclusiveTest()
    {
        List<string> a = new List<string>() { "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" };
        testing(AllInclusiveTask.ContainAllRots("bsjq", a), true);
        a = new List<string>() { };
        testing(AllInclusiveTask.ContainAllRots("", a), true);
        a = new List<string>() { "bsjq", "qbsj" };
        testing(AllInclusiveTask.ContainAllRots("", a), true);
        a = new List<string>() { "TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY" };
        testing(AllInclusiveTask.ContainAllRots("XjYABhR", a), false);

        static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}