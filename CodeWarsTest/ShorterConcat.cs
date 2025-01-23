using CodeWars7kyu;

namespace CodeWarsTest;

public class ShorterConcat
{
    [Test]
    public void ShorterConcatTest()
    {
        try
        {
            string input_a = "abcde";
            string input_b = "fghi";
            string expected = "fghiedcbafghi";

            string actual = ShorterConcatTask.ShorterReverseLonger(input_a, input_b);

            Assert.AreEqual(expected, actual);
        }
        catch (System.Exception ex)
        {
            Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
        }
    }
}