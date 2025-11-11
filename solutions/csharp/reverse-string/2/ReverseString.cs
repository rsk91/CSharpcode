public static class ReverseString
{
    public static string Reverse(string input){
        string arr = new string(input.Reverse().ToArray());
        return arr;
    }
}