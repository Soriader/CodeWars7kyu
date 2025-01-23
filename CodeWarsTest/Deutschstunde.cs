using CodeWars7kyu;

namespace CodeWarsTest;

public class Deutschstunde
{
    [Test]
    public void DeutschstundeTest()
    {
        Assert.AreEqual("der OOOpa", DeutschstundeTask.DerDieDas("OOOpa"));
        Assert.AreEqual("die Suppenhuhn", DeutschstundeTask.DerDieDas("Suppenhuhn"));
        Assert.AreEqual("der Geheimdienst", DeutschstundeTask.DerDieDas("Geheimdienst"));
        Assert.AreEqual("der Ofenkartoffel", DeutschstundeTask.DerDieDas("Ofenkartoffel"));
        Assert.AreEqual("das Fisch", DeutschstundeTask.DerDieDas("Fisch"));
        Assert.AreEqual("die Knödel", DeutschstundeTask.DerDieDas("Knödel"));
        Assert.AreEqual("der Leberkaassemmi", DeutschstundeTask.DerDieDas("Leberkaassemmi"));
    }
}