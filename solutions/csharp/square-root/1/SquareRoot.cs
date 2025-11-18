public static class SquareRoot
{
    public static int Root(int number)
    {
        int num=0;
        for(int i=1;i<=number;i++)
        {
            if((i*i)==number) num=i;
        }
        return num;
    }
}
