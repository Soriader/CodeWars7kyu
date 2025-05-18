namespace CodeWars7kyu;

public class PeterTakesAnExamInSchoolTask
{
    
    public static List<string> PassedStudentList(List<Student> gradeList, int acceptanceGrade)
    {
        var result = new List<string>();

        foreach (var grade in gradeList)
        {
            if (grade.Grade >= acceptanceGrade)
            {
                result.Add(grade.Name);
            }
        }
        
        return result.OrderBy(x => x).ToList();
    }

}

public class Student
{
    public string Name { get; set; }
    public double Grade { get; set; }
}

//https://www.codewars.com/kata/564b0f24c685f1befa000081/train/csharp