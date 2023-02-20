// To the repository class from exercise 1 add an overload to the method GetAll this overload 
// must receive as a parameter a filter delegate to return only the elements that satisfy the filter

using _01;

namespace W_02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new GenericRepository<string>();

            repo.Add(new User("059584483"));
            repo.Add(new User("059584484"));
            repo.Add(new User("059584485"));

            Console.WriteLine(
                string.Join(", ", repo.GetAll(x => x.Id.EndsWith("3")))
            );
        }
    }
}

