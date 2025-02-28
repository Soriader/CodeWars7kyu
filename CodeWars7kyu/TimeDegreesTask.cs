namespace CodeWars7kyu;

public class TimeDegreesTask
{
    public static string ClockDegree(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length != 5 || s[2] != ':')
        {
            return "Check your time !";
        }

        string[] parts = s.Split(':');
        if (parts.Length != 2)
        {
            return "Check your time !";
        }

        if (!int.TryParse(parts[0], out int hours) || !int.TryParse(parts[1], out int minutes))
        {
            return "Check your time !";
        }
        
        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
        {
            return "Check your time !";
        }

        hours = hours % 12;

        int hourAngle = hours * 30;

        int minuteAngle = minutes * 6;

        hourAngle = (int)Math.Round((double)hourAngle);
        minuteAngle = (int)Math.Round((double)minuteAngle);

        hourAngle = hourAngle % 360;
        minuteAngle = minuteAngle % 360;

        if (hourAngle == 0) hourAngle = 360;
        if (minuteAngle == 0) minuteAngle = 360;

        return $"{hourAngle}:{minuteAngle}";
    }
}
//https://www.codewars.com/kata/5782a87d9fb2a5e623000158/train/csharp