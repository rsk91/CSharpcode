public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        int cnt=1;
        string enc="";
        if(string.IsNullOrEmpty(input))
            return "";
        for(int i=1;i<input.Length;i++)
        {
            if(input[i]==input[i-1])
            {
                cnt++;
            }
            else{
                enc+=(cnt>1?cnt.ToString():"")+input[i-1];
                cnt=1;
            }
        }
        enc+=(cnt>1?cnt.ToString():"")+input[input.Length-1];
        return enc;
    }

    public static string Decode(string input)
    {
        string dec="";
        int cnt=0;
        foreach(char i in input)
        {
            if(char.IsDigit(i))
            {
                cnt=cnt*10+(i-'0');
            }
            else
            {
                if(cnt==0) cnt=1;
            for(int j=0;j<cnt;j++)
            {
                dec+=i;
            }
            cnt=0;
            }
        }
        return dec;
    }
}
