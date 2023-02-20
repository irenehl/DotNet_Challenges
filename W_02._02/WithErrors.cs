namespace W_02._02;

public abstract class WithErrors
{
    protected WithErrors()
        {
            Errors = new List<string>();
        }

    protected List<string> Errors { get; set; }

    public abstract bool IsValid();

    public abstract bool HasErrors();
}