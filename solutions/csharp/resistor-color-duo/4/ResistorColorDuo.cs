public static class ResistorColorDuo
{
    public static string[] color = new string[]{"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
    public static int Value(string[] colors)=>(Array.IndexOf(color,colors[0])*10+Array.IndexOf(color,colors[1]));
}

