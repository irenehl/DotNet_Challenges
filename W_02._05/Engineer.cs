namespace _05;

public class Engineer : Employee
{
    // 'Base' is because the parent class has a constructor with 
    // params
    public Engineer(double salary) : base(salary)
    {
    }
}