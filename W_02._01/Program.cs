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

            repo.Delete("059584483");
            
            Console.WriteLine(string.Join(", ", repo.GetAll()));

            Console.WriteLine(repo.Get("059584485"));
            
            repo.Update("059584484", new User("059584486"));
            
            Console.WriteLine(string.Join(", ", repo.GetAll()));
        }
    }
}
