namespace CodeWarsTest;

using CodeWars7kyu;

public class ConvertImproperFractionToMixedNumeral
{
    [Test]
    public void ConvertImproperFractionToMixedNumeralTest()
    {
        ConvertImproperFractionToMixedNumeralTask ConvertImproperFractionToMixedNumeralTask = new ConvertImproperFractionToMixedNumeralTask();
        Assert.That(ConvertImproperFractionToMixedNumeralTask.ConvertToMixedNumeral("6/2"), Is.EqualTo("3"));
        Assert.That(ConvertImproperFractionToMixedNumeralTask.ConvertToMixedNumeral("74/3"), Is.EqualTo("24 2/3"));
        Assert.That(ConvertImproperFractionToMixedNumeralTask.ConvertToMixedNumeral("-504/26"), Is.EqualTo("-19 10/26"));
        Assert.That(ConvertImproperFractionToMixedNumeralTask.ConvertToMixedNumeral("9/18"), Is.EqualTo("9/18"));
    }
}