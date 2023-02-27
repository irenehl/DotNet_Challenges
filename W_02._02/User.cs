namespace W_02._02;

public class User : WithErrors
{
    private int Age { get; set; }
    private bool License { get; set; }
    
    public User(int age, bool license)
    {
        Age = age;
        License = license;
    }

    public override bool IsValid()
    {
        
        if (License && Age >= 18) return true;
        
        if (Age < 18) Errors.Add("User is a child");
        if (!License) Errors.Add("Don't have permission to drive");
        return false;

    }

    public override bool HasErrors()
    {
        return Errors.Count > 0;
     }
}