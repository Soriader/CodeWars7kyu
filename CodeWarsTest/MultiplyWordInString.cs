using CodeWars7kyu;

namespace CodeWarsTest;

public class MultiplyWordInString
{
    [Test]
    public void MultiplyWordInStringTest()
    {
        Assert.AreEqual("is-is-is", MultiplyWordInStringTask.ModifyMultiply("is very easy to resolve that kata", 0, 3), "should return 'is-is-is'");
        Assert.AreEqual("cheap-cheap-cheap-cheap", MultiplyWordInStringTask.ModifyMultiply("Talk is cheap Show me the code", 2, 4), "should return 'cheap-cheap-cheap'");
        Assert.AreEqual("think-think-think-think-think-think", MultiplyWordInStringTask.ModifyMultiply("Everyone in this country should learn how to program because it teaches you how to think", 15, 6), "should return is-is-is");
        Assert.AreEqual("ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance", MultiplyWordInStringTask.ModifyMultiply("Is sloppiness in code caused by ignorance or apathy? I don't know and I don't care.", 6, 8), "should return 'ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance'");
        Assert.AreEqual("around-around-around-around-around", MultiplyWordInStringTask.ModifyMultiply("Everything happening around me is very random. I am enjoying the phase, as the journey is far more enjoyable than the destination.", 2, 5), "should return'around-around-around-around-around'");
    }
}