namespace _05;

public class Manager : Employee
{
    // Property
    private double Bonus { get; set; }

    // Method
    public new double GetPaymentAmount()
    {
        return base.GetPaymentAmount() + Bonus;
    }

    // Constructor
    public Manager(double salary, double bonus) : base(salary)
    {
        Bonus = bonus;
    }
}