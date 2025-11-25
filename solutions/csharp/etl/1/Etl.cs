public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old){
        var word=new Dictionary<string,int>();
        foreach(var i in old)
            foreach(var v in i.Value)
                word.Add(v.ToLower(),i.Key);
        return word;
    }
}