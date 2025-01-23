using CodeWars7kyu;

namespace CodeWarsTest;

public class ScalingSquaredStrings
{
    [Test]
    public static void ScalingSquaredStringsTest()
    {
                    
        string a = "abcd\nefgh\nijkl\nmnop";
        string r = "aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\n"
                   + "iijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp";
        testing(ScalingSquaredStringsTask.Scale(a, 2, 3), r);
        testing(ScalingSquaredStringsTask.Scale("", 5, 5), "");
        testing(ScalingSquaredStringsTask.Scale("Kj\nSH", 1, 2), "Kj\nKj\nSH\nSH");


        static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}