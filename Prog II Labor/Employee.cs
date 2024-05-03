namespace Prog_II_Labor;

public class Employee
{
    public String Name;
    public String Department;

    public virtual double CalculateSalary()
    {
        return 0D;
    }

    public static void TestApplication()
    {
        var eA = new PermanentEmployee();
        var eB = new HourlyWageWorker();
        eB.HourlyWage = 15D;
        eB.AddHours(178.52);
        Console.WriteLine("eA: " + eA.CalculateSalary());
        Console.WriteLine("eB: " + eB.CalculateSalary());
    }
    
}