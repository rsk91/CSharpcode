public static class Pangram
{
    public static bool IsPangram(string input)=>input.ToLower().Where(c=>char.IsLetter(c)).Distinct().Count()==26;
}
