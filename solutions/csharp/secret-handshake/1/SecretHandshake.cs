public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var secret = new List<string>();
        if((commandValue&1)!=0)
            secret.Add("wink");
        if((commandValue&2)!=0)
            secret.Add("double blink");
        if((commandValue&4)!=0)
            secret.Add("close your eyes");
        if((commandValue&8)!=0)
            secret.Add("jump");
        if((commandValue&16)!=0)
            secret.Reverse();
        return secret.ToArray();
    }
}

                    