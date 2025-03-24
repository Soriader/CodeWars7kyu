namespace CodeWars7kyu;

public class PitchesAndNotesTask
{
    public static Dictionary<double, string> NotesDictionary = new Dictionary<double, string>()
    {
        {440, "A"},
        {466.16, "A#"},
        {493.88, "B"},
        {523.25, "C"},
        {554.37, "C#"},
        {587.33, "D"},
        {622.25, "D#"},
        {659.25, "E"},
        {698.46, "F"},
        {739.99, "F#"},
        {783.99, "G"},
        {830.61, "G#"}
    };
    
    public static string GetNote(double pitch)
    {
        double currentPitch = pitch;
    
        while (currentPitch <= 830.61 * 2)
        {
            if (NotesDictionary.TryGetValue(currentPitch, out var note))
            {
                return note;
            }   
            currentPitch *= 2;
        }
    
        currentPitch = pitch;
    
        while (currentPitch >= 440 / 2)
        {
            if (NotesDictionary.TryGetValue(currentPitch, out var note))
            {
                return note;
            }   
            currentPitch /= 2;
        }
    
        return "";
    }
}
//https://www.codewars.com/kata/5a0599908ba914a6cf000138/train/csharp