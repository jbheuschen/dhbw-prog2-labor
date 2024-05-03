namespace Prog_II_Labor;

public class HourlyWageWorker : Employee
{

    public double WorkedHours { get; private set;  }= 0D;
    public double HourlyWage = 12.5D;

    public void AddHours(double hours = 1D)
    {
        WorkedHours += hours;
    }
    
    public override double CalculateSalary()
    {
        return WorkedHours * HourlyWage;
    }
}