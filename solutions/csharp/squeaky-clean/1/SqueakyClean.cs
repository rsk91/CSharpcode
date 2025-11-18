using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<identifier.Length; i++)
        {
            if(char.IsWhiteSpace(identifier[i]))
                sb.Append('_');
            else if(char.IsControl(identifier[i]))
                sb.Append("CTRL");
            else if(char.IsLetter(identifier[i])&&!(char.IsBetween(identifier[i],'α', 'ω')))
                sb.Append(identifier[i]);
            else if(identifier[i]=='-'&&(char.IsLower(identifier[i+1])))
                {
                    sb.Append(char.ToUpper(identifier[i+1]));
                    i++;
                }
        }
        return sb.ToString();
    }
}
