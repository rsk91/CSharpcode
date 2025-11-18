using System.Text;
public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string newtext="";
        foreach(char c in text)
        {
            if(char.IsLetter(c))
            {
                char letter = char.IsUpper(c)?'A':'a';
                char chiper = (char)(((c-letter+shiftKey)%26)+letter);
                newtext+=chiper;
            }
            else
            {
                newtext+=c;
            }
        }
        return newtext;
        }
        
}

/*var newtext = new StringBuilder();
        foreach(char c in text)
        {
            if(char.IsLetter(c))
            {
                char letter = char.IsUpper(c)?'A':'a';
                char chiper = (char)(((c-letter+shiftKey)%26)+letter);
                newtext.Append(chiper);
            }
            else
            {
                newtext.Append(c);
            }
        }
        return newtext.ToString();
        }*/