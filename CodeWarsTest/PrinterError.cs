using CodeWars7kyu;

namespace CodeWarsTest;

public class PrinterError
{
    [Test]
    public static void PrinterErrorTest()
    {
        Assert.AreEqual("3/56", PrinterErrorTask.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
    }
}