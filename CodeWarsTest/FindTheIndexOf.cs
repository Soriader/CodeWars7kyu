using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheIndexOf
{
    [Test]
    public void FindTheIndexOfTest()
    {
        Assert.AreEqual(3, FindTheIndexOfTask.SecondSymbol("Hello world!!", 'l'), "Find the index of the second symbol \"l\" in the string");
        Assert.AreEqual(7, FindTheIndexOfTask.SecondSymbol("Hello world!!", 'o'), "Find the index of the second symbol \"o\" in the string");
        Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("Hello world!!", 'A'), "The symbol \"A\" is not in the string");
        Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("", 'q'), "The symbol \"q\" is not in the string");
        Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("Hello", '!'), "The symbol \"!\" is not in the string");
        Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("lHgMvSCkzgRgmSUtfSWnWENGgADkfLaYMbrjjzJp", 'l'));
    }
}