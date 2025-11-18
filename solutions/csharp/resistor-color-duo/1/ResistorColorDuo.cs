public static class ResistorColorDuo
{
    public static int Value(string[] colors){
        string val="";
        var color=new Dictionary<string,int>()
        {
            {"black",0},{"brown",1},{"red",2},{"orange",3},{"yellow",4},{"green",5},{"blue",6},{"violet",7},{"grey",8},{"white",9}};
        for(int i=0; i<2; i++)
        {
            val+= color[colors[i]];
        }
        return Convert.ToInt32(val);
    }
}
