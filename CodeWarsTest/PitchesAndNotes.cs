namespace CodeWarsTest;

using CodeWars7kyu;

public class PitchesAndNotes
{
    [Test]
    public void PitchesAndNotesTest()
    {
        Assert.That(PitchesAndNotesTask.GetNote(440), Is.EqualTo("A"));
        Assert.That(PitchesAndNotesTask.GetNote(220), Is.EqualTo("A"));
        Assert.That(PitchesAndNotesTask.GetNote(880), Is.EqualTo("A"));
      
        Assert.That(PitchesAndNotesTask.GetNote(523.25), Is.EqualTo("C"));
        Assert.That(PitchesAndNotesTask.GetNote(261.625), Is.EqualTo("C"));
        Assert.That(PitchesAndNotesTask.GetNote(1046.5), Is.EqualTo("C"));
    }
}