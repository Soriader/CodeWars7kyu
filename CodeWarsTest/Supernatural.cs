namespace CodeWarsTest;

using CodeWars7kyu;

public class Supernatural
{
    [Test]
    public static void SupernaturalTest()
    {
        Assert.That(SupernaturalTask.Bob("vampire"), Is.EqualTo("Behead it with a machete, idjits!"));
        Assert.That(SupernaturalTask.Bob("pagan god"), Is.EqualTo("It depends on which one it is, idjits!"));
        Assert.That(SupernaturalTask.Bob("werepuppy"), Is.EqualTo("I have friggin no idea yet, idjits!"));
    }
}