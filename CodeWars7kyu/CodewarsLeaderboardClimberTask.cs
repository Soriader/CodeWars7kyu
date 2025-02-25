namespace CodeWars7kyu;

public class CodewarsLeaderboardClimberTask
{
    public static string LeaderB(string user, int user_score, int your_score)
    {
        int diff = user_score - your_score;
       
        if(diff < 0)
        {
            return "Winning!";
        }        
        
        if(diff == 0)
        {
            return "Only need one!";
        }
        int pointsNeeded = diff;
    
        int beta = pointsNeeded / 3;
        int eight = pointsNeeded % 3;
    
        string result = $"To beat {user}'s score, I must complete {beta} Beta kata and {eight} 8kyu kata.";
        
        if(beta >= 1000)
        {
            result += " Dammit!";
        }
        return result;
    }
}
//https://www.codewars.com/kata/57d28215264276ea010002cf/train/csharp