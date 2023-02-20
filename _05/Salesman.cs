namespace _05;

public class Salesman : Employee
{
    // Properties
    private double Commission { get; set; }

    // Method
    public new double GetPaymentAmount()
    {
        return base.GetPaymentAmount() + Commission;
    }

    // Constructor
    public Salesman(double salary, double commission) : base(salary)
    {
        Commission = commission;
    }
}