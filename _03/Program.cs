namespace _03;

public class Program
{
    public static void Main(string[] args)
    {
        ToRoman(213);
    }

    public static Dictionary<string, int> RomanNumbers = new()
    { 
        { "I", 1 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 }
    };

    public static string ToRoman(int number)
    {
        if (number > 3000) return "LIMIT EXCEEDED";

        var result = string.Empty;
        
        foreach (var pair in RomanNumbers.Reverse())
        {
            if (number <= 0) break;
            
            while (number >= pair.Value)
            {
                result += pair.Key;
                number -= pair.Value;
            }
        }

        return result;
    }
}