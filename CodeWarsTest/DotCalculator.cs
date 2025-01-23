using CodeWars7kyu;

namespace CodeWarsTest;

public class DotCalculator
{
    [Test]
    public void DotCalculatorTest()
    {
        Assert.AreEqual("....................", DotCalculatorTask.Calculator("..... + ..............."));
        Assert.AreEqual("..", DotCalculatorTask.Calculator("..... - ..."));
        Assert.AreEqual("....", DotCalculatorTask.Calculator("..... - ."));
        Assert.AreEqual("...............", DotCalculatorTask.Calculator("..... * ..."));
        Assert.AreEqual("..........", DotCalculatorTask.Calculator("..... * .."));
        Assert.AreEqual("..", DotCalculatorTask.Calculator("..... // .."));
        Assert.AreEqual(".....", DotCalculatorTask.Calculator("..... // ."));
        Assert.AreEqual("", DotCalculatorTask.Calculator(". // .."));
        Assert.AreEqual("", DotCalculatorTask.Calculator(". - ."));
    }
}