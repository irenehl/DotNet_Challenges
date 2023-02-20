namespace W_02._02;

public class User : WithErrors
{
    private int Age { get; set; }
    
    public User(int age)
    {
        Age = age;
    }

    public override bool IsValid()
    {
        if (Age >= 18) return true;
        
        Errors.Add("User is underage");
        return false;

    }

    public override bool HasErrors()
    {
        return Errors.Count > 0;
    }
}