public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int count=0;
        string num=Convert.ToString(encodedCount,2);
        for(int i=0;i<num.Length;i++)
        {
            if(num[i]=='1')
            {
                count++;
            }    
        }
        return count;
    }
}
