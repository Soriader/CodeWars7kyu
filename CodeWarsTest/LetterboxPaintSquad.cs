using CodeWars7kyu;

namespace CodeWarsTest;

public class LetterboxPaintSquad
{
    [Test]
    public void LetterboxPaintSquadTest()
    {
        Assert.AreEqual(new int[] { 1, 9, 6, 3, 0, 1, 1, 1, 1, 1 }, LetterboxPaintSquadTask.PaintLetterBoxes(125, 132).ToArray());
    }
}