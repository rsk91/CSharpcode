public static class ResistorColorDuo
{
        public static Dictionary<string,string> color =new Dictionary<string,string>()
        {
            {"black","0"},{"brown","1"},{"red","2"},{"orange","3"},{"yellow","4"},{"green","5"},{"blue","6"},{"violet","7"},{"grey","8"},{"white","9"}};
    
    public static int Value(string[] colors)
    {
        return int.Parse((color[colors[0]])+(color[colors[1]]));
    }
}
