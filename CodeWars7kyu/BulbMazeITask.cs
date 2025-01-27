namespace CodeWars7kyu;

public class BulbMazeITask
{
    public static bool BulbMaze(string maze)
    {
        var secondCombination = maze.Replace('x', 'z').Replace('o', 'x').Replace('z', 'o');
        
        int iterator = 0;

        while (iterator != maze.Length)
        {
            if (iterator % 2 == 0)
            {
                if (maze[iterator] == 'o')
                {
                    return false;
                }  
            }
            else if (!(iterator % 2 == 0))
            {
                if (secondCombination[iterator] == 'o')
                {
                    return false;
                }  
            }
            
            iterator++;
        }
        
        return true;
    }
}
//https://www.codewars.com/kata/59c0b9d4cb7fb4dd41000962/train/csharp