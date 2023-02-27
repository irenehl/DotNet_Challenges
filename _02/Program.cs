namespace _02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static bool CheckParenthesis(string str)
        {
            var opened = 0;
            var closed = 0;
            
            if (!str.Contains('(') && !str.Contains(')')) return true;

            var startingFlag = true;
            
            foreach (var ch in str)
            {
                switch (ch)
                {
                    case ')' when startingFlag:
                        return false;
                    case '(':
                        opened++;
                        startingFlag = false;
                        break;
                    case ')':
                        closed++;
                        startingFlag = false;
                        break;
                }
            }

            return opened == closed;
        }
    }
}