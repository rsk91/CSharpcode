public static class Darts
{
    public static int Score(double x, double y)=>Area(x,y)<=1?10:Area(x,y)<=5?5:Area(x,y)<=10?1:0;
    public static double Area(double a, double b)=>Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
}
