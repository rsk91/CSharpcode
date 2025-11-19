public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string s ="abcdefghijklmnopqrstuvwxyz";
        return s.All(input.ToLower().Contains);
    }
}
