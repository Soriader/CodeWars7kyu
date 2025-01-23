using CodeWars7kyu;

namespace CodeWarsTest;

public class AllOrNothing
{
    [Test]
    public void AllOrNothingTest()
    {
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "A", "_", "C", "_", "B" }, new[] { "A", "D", "C", "E", "B" }));
        Assert.AreEqual(false, AllOrNothingTask.PossiblyPerfect(new[] { "B", "_", "B" }, new[] { "B", "D", "C" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "T", "_", "F", "F", "F" }, new[] { "F", "F", "T", "T", "T" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "B", "A", "_", "_" }, new[] { "B", "A", "C", "C" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "A", "B", "A", "_" }, new[] { "B", "A", "C", "C" }));
        Assert.AreEqual(false, AllOrNothingTask.PossiblyPerfect(new[] { "A", "B", "C", "_" }, new[] { "B", "A", "C", "C" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "B", "_" }, new[] { "C", "A" }));
        Assert.AreEqual(false, AllOrNothingTask.PossiblyPerfect(new[] { "B", "A" }, new[] { "C", "A" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "B" }, new[] { "B" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "_", "T", "_", "_" }, new[] { "T", "F", "F", "F" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "_", "T", "_", "_" }, new[] { "T", "T", "F", "T" }));
        Assert.AreEqual(false, AllOrNothingTask.PossiblyPerfect(new[] { "_", "T", "T", "T" }, new[] { "T", "T", "F", "T" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "_", "T", "T", "T" }, new[] { "T", "T", "T", "T" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "_", "T", "T", "T" }, new[] { "F", "F", "F", "F" }));
        Assert.AreEqual(true, AllOrNothingTask.PossiblyPerfect(new[] { "_", "_", "_", "_" }, new[] { "F", "F", "F", "F" }));
    }
}