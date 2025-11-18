public static class ReverseString
{
    public static string Reverse(string input){
        string wrd="";
        for(int i=0;i<input.Length;i++)
        {
            wrd+=input[input.Length-i-1];
        }
        return wrd;
    }
}