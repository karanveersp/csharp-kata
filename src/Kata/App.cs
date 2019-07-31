namespace Kata
{
    public class App
    {
        public static string GetGreeting(string name)
        {
            if (name != null && name != "")
            {
                return $"Hello, {name}!";
            }
            else
            {
                return "Hello, bub";
            }
        }
    }
}