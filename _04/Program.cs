namespace _04;

public class Program
{
    public static void Main(string[] args)
    {
        var names = Console.ReadLine();

        Console.WriteLine(Notify(names ?? ""));
    }

    public static string Notify(string raw)
    {
        var names = raw.Split(' ');

        if (names.Length > 2) return $"{names[0]}, {names[1]} and {names.Length - 2} others like your post";
        if (names.Length == 2) return $"{names[0]} and {names[1]} like your post";

        return $"{names[0]} likes your post";
    }
}