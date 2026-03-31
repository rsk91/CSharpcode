public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var res = new List<int>();
        foreach(int i in multiples)
        {
            if(i==0) continue;
            for(int j=i; j<max; j+=i)
            {
                res.Add(j);
            }
        }
        var newres = res.Distinct().OrderBy(c=>c).Sum();
        return newres;
    }
}