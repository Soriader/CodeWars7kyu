using CodeWars7kyu;

namespace CodeWarsTest;

public class BulbMazeI
{
    [TestCase("xo oxox", ExpectedResult = true)]
    [TestCase("xo  oxox", ExpectedResult = false)]
    [TestCase("xo ox xo", ExpectedResult = true)]
    [TestCase("xooxxo", ExpectedResult = false)]
    [TestCase("xxxxxx", ExpectedResult = false)]
    [TestCase("oooooo", ExpectedResult = false)]
    [TestCase("      ", ExpectedResult = true)]
    [TestCase(" ox", ExpectedResult = true)]
    [TestCase("xo", ExpectedResult = true)]
    [TestCase("x", ExpectedResult = true)]
    [TestCase("o", ExpectedResult = false)]
    public bool Sample_Cases(string s) => BulbMazeITask.BulbMaze(s);
}
