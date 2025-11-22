public static class Luhn
{
    public static bool IsValid(string number)
    {
        int sum=0;
        int cnt=0;
        for(int i=number.Length-1; i>=0; i--)
        {
            if(char.IsNumber(number[i]))
            {
                int num = (int)(number[i]-'0');
                if(cnt%2!=0)
                    num=(num*2>9)?(num*2-9):num*2;
                cnt++;
                sum+=num;
            }
            else if(!char.IsWhiteSpace(number[i]))
                return false;
        }
        if(cnt<2)
            return false;
        return sum%10==0;
                
        
    }
}