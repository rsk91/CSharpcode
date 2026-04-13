public class Robot
{
    private static int num;
    public string Name
    {
        get;private set; 
    }
    public Robot()=>GenerateName(++num);
    private void GenerateName(int num)
    {
            Random r = new Random(num);
            Name= $"{(char)(r.Next('A','Z'+1))}{(char)(r.Next('A','Z'+1))}{r.Next(0,1000):d3}";
    }
    public void Reset()=>GenerateName(++num);
}