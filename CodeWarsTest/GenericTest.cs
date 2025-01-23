using CodeWars7kyu;

namespace CodeWarsTest;

public class GenericTest
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", InterviewQuestionTask.GetStrings("Chicago"));
        Assert.AreEqual("b:*,a:*,n:*,g:*,k:**,o:*", InterviewQuestionTask.GetStrings("Bangkok"));
        Assert.AreEqual("l:*,a:**,s:**,v:*,e:*,g:*", InterviewQuestionTask.GetStrings("Las Vegas"));
    }
}