namespace CodeWarsTest;

using CodeWars7kyu;

public class MisleadingSigns
{
        [TestCase("snack", "snake", new char[] {'c'}, ExpectedResult = true)]
        [TestCase("snack", "snack", new char[] {'s', 'n', 'a', 'c', 'k'}, ExpectedResult = false)]
        [TestCase("snake", "snack", new char[] { 'c' }, ExpectedResult = true)]
        [TestCase("ping", "pong", new char[] { 'p', 'n', 'g' }, ExpectedResult = false)]
        [TestCase("ping", "pong", new char[] { 'i' }, ExpectedResult = true)]
        public bool Sample_Cases(string s, string y, char[] f) => MisleadingSignsTask.Gaslighting(s, y, f);
}