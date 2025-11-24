public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string newval="";
        string val = phrase.Replace("_","").Replace("-"," ");
        for(int i=0;i<val.Length;i++)
        {
            if(char.IsWhiteSpace(val[i]))
                newval+=char.ToUpper(val[i+1]);
        }
        return (val[0]+newval).Replace(" ","");
    }
}