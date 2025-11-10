public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int val=0; int newval=0;
        for(int i=0;i<input.Length;i++)
            {
            val=("AEIOULNRSTaeioulnrst".Contains(input[i])?1:("DGdg".Contains(input[i]))?2:("BCMPbcmp".Contains(input[i]))?3:("FHVWYfhvwy".Contains(input[i]))?4:"Kk".Contains(input[i])?5:"JXjx".Contains(input[i])?8:10);
            newval+=val;
            }
        return newval;
    }  
}