using _01;

namespace W_02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new GenericRepository<string>();

            repo.Add(new User("059584483"));
            repo.Add(new User("059584484"));
            repo.Add(new User("059584485"));

            Console.WriteLine(string.Join(", ", repo.GetAll()));
        }
    }
}
