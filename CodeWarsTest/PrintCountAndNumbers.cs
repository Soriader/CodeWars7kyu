using CodeWars7kyu;

namespace CodeWarsTest;

public class PrintCountAndNumbers
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("1123").Returns("211213");
            yield return new TestCaseData("1").Returns("11");
            yield return new TestCaseData("a").Returns("");
            yield return new TestCaseData("11").Returns("21");
            yield return new TestCaseData("a123").Returns("");
            yield return new TestCaseData("21").Returns("1211");
            yield return new TestCaseData("1211").Returns("111221");
            yield return new TestCaseData("12322212223443").Returns("111213321132132413");
            yield return new TestCaseData("").Returns("");
            yield return new TestCaseData("123a").Returns("");
        }
    }
  
    [Test, TestCaseSource("testCases")]
    public string Test(string data) => PrintCountAndNumbersTask.CountMe(data);
}
