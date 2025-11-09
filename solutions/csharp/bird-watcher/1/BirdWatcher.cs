class BirdCount
{
    private int[] birdsPerDay;
    int birds;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }
    public static int[] LastWeek()=> new int[]{0,2,5,3,7,8,4};
    public int Today()=> birdsPerDay[birdsPerDay.Length-1];
    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1]+=1;
    }
    public bool HasDayWithoutBirds()
    {
        for(int i=0; i<birdsPerDay.Length;i++)
            if(birdsPerDay[i]==0)
                return true;
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        for(int i=0; i<numberOfDays;i++)
             birds+=birdsPerDay[i];
        return birds;
    }

    public int BusyDays()
    {
        int busy=0;
        for(int i=0; i<birdsPerDay.Length;i++)
            if(birdsPerDay[i]>=5)
                busy++;
        return busy;
    }
}
