using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheVowels
{
    [Test]
    public void FindTheVowelsTest()
    {
        Assert.AreEqual(new int[] { }, FindTheVowelsTask.VowelIndices("mmm"));
        Assert.AreEqual(new int[] { 1, 5 }, FindTheVowelsTask.VowelIndices("apple"));
        Assert.AreEqual(new int[] { 2, 4 }, FindTheVowelsTask.VowelIndices("super"));
        Assert.AreEqual(new int[] { 1, 3, 6 }, FindTheVowelsTask.VowelIndices("orange"));
        Assert.AreEqual(new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 }, FindTheVowelsTask.VowelIndices("supercalifragilisticexpialidocious"));
    }
}