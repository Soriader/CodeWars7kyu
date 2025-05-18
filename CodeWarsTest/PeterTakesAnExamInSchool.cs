namespace CodeWarsTest;

using CodeWars7kyu;

public class PeterTakesAnExamInSchool
{
    [Test]
    public void PeterTakesAnExamInSchoolTestFirst()
    {
        List<Student> gradeList = new List<Student>()
        {
            new Student() {Name = "aaca", Grade = 10.25},
            new Student() {Name = "aaab", Grade = 10},
            new Student() {Name = "aabb", Grade = 9.75},
            new Student() {Name = "aabbb", Grade = 10.75},
            new Student() {Name = "aab", Grade = 10.5}
        };
        List<string> stringList = new List<string>(){"aaab","aab","aabbb","aaca"};
        Assert.That(PeterTakesAnExamInSchoolTask.PassedStudentList(gradeList, 10), Is.EqualTo(stringList));
    }

    [Test]
    public void PeterTakesAnExamInSchoolTestSecond()
    {
        List<Student> gradeList = new List<Student>()
        {
            new Student() {Name = "Joey", Grade = 10.25},
            new Student() {Name = "Bob", Grade = 10.5},
            new Student() {Name = "Petri", Grade = 10.70},
            new Student() {Name = "Peter", Grade = 10.75},
            new Student() {Name = "Patrick", Grade = 10.5},
            new Student() {Name = "Sarah", Grade = 10.5},
            new Student() {Name = "Anna", Grade = 9.75},
            new Student() {Name = "Andy", Grade = 10.75},
            new Student() {Name = "Joel", Grade = 10.5}
        };
        List<string> stringList = new List<string>() { "Andy", "Anna", "Bob", "Joel", "Joey", "Patrick", "Peter", "Petri", "Sarah" };
        Assert.That(PeterTakesAnExamInSchoolTask.PassedStudentList(gradeList, 9), Is.EqualTo(stringList));
    }
}