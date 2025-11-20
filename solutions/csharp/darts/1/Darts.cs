public static class Darts
{
    public static int Score(double x, double y)
    {
        double val = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
        if(val<=10 && val>5) return 1;
        else if(val>1&&val<=5) return 5;
        else if(val>=0&&val<=1) return 10;
        else return 0;
    }
}
