using W_02._02;

namespace W_02._03;

public static class WithErrorsExtensions
{
    public static string Format(this WithErrors errors)
    {
        return string.Join(", ", errors.Errors);
    }
}