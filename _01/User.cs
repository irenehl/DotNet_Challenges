namespace _01;

public class User : IEntity<string>
{
    public string Id { get; set; }

    public User(string id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return $"Id: {Id}";
    }
}