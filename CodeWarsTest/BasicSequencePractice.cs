using CodeWars7kyu;

namespace CodeWarsTest;

public class BasicSequencePractice
{
    [Test]
    public void BasicSequencePracticeTest()
    {
        int input = 3;
        int[] expected = new int[] { 0, 1, 3, 6 };

        int[] actual = BasicSequencePracticeTask.SumOfN(input);

        Assert.AreEqual(expected, actual);

    }
}