using CodeWars7kyu;

namespace CodeWarsTest;

public class FormattingDecimalPlaces
{
    [Test]
    public void FormattingDecimalPlacesTest()
    {
        Assert.AreEqual(10.12, FormattingDecimalPlacesTask.TwoDecimalPlaces(10.1289767789));
        Assert.AreEqual(-7488.83, FormattingDecimalPlacesTask.TwoDecimalPlaces(-7488.83485834983));

    }
}