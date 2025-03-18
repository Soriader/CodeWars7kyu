namespace CodeWars7kyu;

public class AirportItineraryTask
{
    public static string Itinerary(Route[] travel)
    { 
        if (travel == null || travel.Length == 0)
        {
            return "";
        }

        var airports = new List<string>();
        
        foreach (var segment in travel)
        {
            if (!airports.Contains(segment.In))
            {
                airports.Add(segment.In);
            }
            airports.Add(segment.Out);
        }

        return string.Join("-", airports);
    }
}

public class Route
{
    public string In;
    public string Out;
}

//https://www.codewars.com/kata/57a72cb872292dc43100000c/train/csharp