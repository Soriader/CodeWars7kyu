using CodeWars7kyu;

namespace CodeWarsTest;

public class TurkishNumbers
{
    [Test]
    public void TurkishNumbersTest()
    {
        int[] exampleInputs = new int[] { 1, 13, 27, 38, 77, 94 };
        string[] exampleOutputs = new string[] { "bir", "on üç", "yirmi yedi", "otuz sekiz", "yetmiş yedi", "doksan dört" };

        for (int i = 0; i < exampleInputs.Length; i++)
            Assert.AreEqual(exampleOutputs[i], TurkishNumbersTask.GetTurkishNumber(exampleInputs[i]));
    }
}