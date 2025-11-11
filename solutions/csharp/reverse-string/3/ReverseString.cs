public static class ReverseString
{
    public static string Reverse(string input){
        string wrd="";
        for(int i=0;i<=input.Length-1;i++)
        {
            wrd+=input[input.Length-i-1];
        }
        return wrd;
    }
}