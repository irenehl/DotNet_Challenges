using W_02._02;

namespace W_02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(12);

            Console.WriteLine("Is Valid: " + user.IsValid());
            Console.WriteLine("Has errors: " + user.HasErrors());

            Console.WriteLine(user.Format());
        }
    }
}

