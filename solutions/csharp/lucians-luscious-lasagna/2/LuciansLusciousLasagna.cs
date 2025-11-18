class Lasagna
{
        public int ExpectedMinutesInOven()
        {

            int t = 40;
            return t;
        }

        public int RemainingMinutesInOven(int rtime)
        {
            int rt = 40 - rtime;
            return rt;
        }

        public int PreparationTimeInMinutes(int pr)
        {
            int prept = 2 * pr;
            return prept;
        }
        public int ElapsedTimeInMinutes(int t1, int t2)
        {
            int et = t1*2 + t2;
            return et;
        }
}
