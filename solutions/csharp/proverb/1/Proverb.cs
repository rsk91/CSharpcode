public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var message = new List<string>();
        for(int i=0;i<subjects.Length-1;i++)
        {
            message.Add($"For want of a {subjects[i]} the {subjects[i+1]} was lost.");
        }
        if(subjects.Length>0) message.Add($"And all for the want of a {subjects[0]}.");
        return message.ToArray();
    }
}