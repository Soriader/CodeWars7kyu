using CodeWars7kyu;

namespace CodeWarsTest;

public class BuildASquare
{
    [Test]
    public void BuildASquareTest()
    {
        Assert.AreEqual("", BuildASquareTask.GenerateShape(0));
        Assert.AreEqual("+", BuildASquareTask.GenerateShape(1));
        Assert.AreEqual("++\n++", BuildASquareTask.GenerateShape(2));
        Assert.AreEqual("+++\n+++\n+++", BuildASquareTask.GenerateShape(3));
    }
}