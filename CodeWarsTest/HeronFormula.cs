using CodeWars7kyu;

namespace CodeWarsTest;

public class HeronFormula
{
    [Test]
    public void HeronFormulaTest()
    {

        Assert.AreEqual(6.0, HeronFormulaTask.Heron(3, 4, 5));
        Assert.AreEqual(24.0, HeronFormulaTask.Heron(6, 8, 10));

    }
}