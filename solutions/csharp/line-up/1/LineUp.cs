public static class LineUp
{
    public static string Format(string name, int number)
    {
        int num=number;
        if(num>20)
            if(num%100>10&&num%100<21)
                num=num%100;
            else
                num=num%10;
        var ord=num switch{
                1=>"st", 
                2=>"nd",
                3=>"rd",
                >10 and <20=>"th",
                _=>"th"
        };
        return $"{name}, you are the {number}{ord} customer we serve today. Thank you!";
    }
}
