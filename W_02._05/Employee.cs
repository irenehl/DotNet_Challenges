namespace _05;

public class Employee
{
    // Property
    private double Salary { get; set; }
    
    // Method
    protected Employee(double salary)
    {
        Salary = salary;
    }

    // Constructor
    public double GetPaymentAmount()
    {
        return Salary;
    }
}