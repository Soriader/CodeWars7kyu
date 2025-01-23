using CodeWars7kyu;

namespace CodeWarsTest;

public class PutALetterInAColumn
{
    [Test]
    public void PutALetterInAColumnTest()
    {
        Assert.AreEqual("| | |A| | | | | | |", PutALetterInAColumnTask.BuildRowText(2, 'A'));
        Assert.AreEqual("|A| | | | | | | | |", PutALetterInAColumnTask.BuildRowText(0, 'A'));
        Assert.AreEqual("| | | | | | | | |A|", PutALetterInAColumnTask.BuildRowText(8, 'A'));
    }
}