using CodeWars7kyu;

namespace CodeWarsTest;

public class MoveAllVowels
{
    [Test]
    public void MoveAllVowelsTest()
    {
        Assert.That(MoveAllVowelsTask.MoveVowel("day"), Is.EqualTo("dya"));
        Assert.That(MoveAllVowelsTask.MoveVowel("apple"), Is.EqualTo("pplae"));
        Assert.That(MoveAllVowelsTask.MoveVowel("peace"), Is.EqualTo("pceae"));
        Assert.That(MoveAllVowelsTask.MoveVowel("maker"), Is.EqualTo("mkrae"));
    }
}