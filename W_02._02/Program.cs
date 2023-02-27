// Usually, when we have validations, we need to notify the parent method of possible
// errors or return a value. Create a class that allows you to achieve that goal.
// Required  methods: IsValid(), HasErrors()
// Note. There may be more than one error message.

namespace W_02._02;

class Program
{
    static void Main(string[] args)
    {
        var user = new User(13, false);

        Console.WriteLine("Is Valid: " + user.IsValid());
        Console.WriteLine("Has errors: " + user.HasErrors());
    }
}