using CodeWars7kyu;

namespace CodeWarsTest;

public class MovesInSquaredStrings
{
    [Test]
    public static void MovesInSquaredStringsTest()
    {
        Console.WriteLine("Fixed Tests VertMirror");
        testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.VertMirror, "hSgdHQ\nHnDMao\nClNNxX\niRvxxH\nbqTVvA\nwvSyRu"),
            "QHdgSh\noaMDnH\nXxNNlC\nHxxvRi\nAvVTqb\nuRySvw");
        testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.VertMirror, "IzOTWE\nkkbeCM\nWuzZxM\nvDddJw\njiJyHF\nPVHfSx"),
            "EWTOzI\nMCebkk\nMxZzuW\nwJddDv\nFHyJij\nxSfHVP");

        Console.WriteLine("Fixed Tests HorMirror");
        testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.HorMirror, "lVHt\nJVhv\nCSbg\nyeCt"), "yeCt\nCSbg\nJVhv\nlVHt");
        testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.HorMirror, "njMK\ndbrZ\nLPKo\ncEYz"), "cEYz\nLPKo\ndbrZ\nnjMK");

        static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}