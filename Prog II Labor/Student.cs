namespace Prog_II_Labor;

public class Student
{
    public string Name = "";
    public long StudentNumber = -1;
    public DateTime DateOfBirth = DateTime.Today;
    public List<int> Grades = new List<int>();

    public Student()
    {
        
    }

    public void AddGrade(int grade)
    {
        if (0 < grade & grade < 7)
        {
            Grades.Add(grade);
        }
    }

    public double AvgGrade()
    {
        return Grades.Average();
    }

    public int Age()
    {
        return new DateTime((DateTime.Now - DateOfBirth).Ticks).Year;
    }

    public void Information()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Matrikelnummer: " + StudentNumber);
        Console.WriteLine("Age: " + Age());
        Console.WriteLine("AvgGrade: " + AvgGrade());
    }
    
}