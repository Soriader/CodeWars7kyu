using CodeWars7kyu;

namespace CodeWarsTest;

public class ComposingSquaredStrings
{
    [Test]
    public static void ComposingSquaredStringsTest()
    {
        static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        testing(ComposingSquaredStringsTask.Compose("byGt\nhTts\nRTFF\nCnnI", "jIRl\nViBu\nrWOb\nNkTB"),
            "bNkTB\nhTrWO\nRTFVi\nCnnIj");
        testing(ComposingSquaredStringsTask.Compose("HXxA\nTGBf\nIPhg\nuUMD", "Hcbj\nqteH\nGbMJ\ngYPW"),
            "HgYPW\nTGGbM\nIPhqt\nuUMDH");
        testing(ComposingSquaredStringsTask.Compose("tSrJ\nOONy\nsqPF\nxMkB", "hLqw\nEZuh\nmYFl\nzlYf"),
            "tzlYf\nOOmYF\nsqPEZ\nxMkBh");
    }
}