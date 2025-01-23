using System.Numerics;
using CodeWars7kyu;

namespace CodeWarsTest;

public class EasyLine
{
    [Test]
    public static void EasyLineTest()
    {
        static void testing(BigInteger actual, BigInteger expected)
        {
            Assert.AreEqual(expected, actual);
        }

        testing(EasyLineTask.EasyLine(7), BigInteger.Parse("3432"));
        testing(EasyLineTask.EasyLine(13), BigInteger.Parse("10400600"));
        testing(EasyLineTask.EasyLine(17), BigInteger.Parse("2333606220"));
        testing(EasyLineTask.EasyLine(19), BigInteger.Parse("35345263800"));
    }
}