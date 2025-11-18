static class SavingsAccount
{
    public static float InterestRate(decimal balance)=>((balance>=0m)?((balance>=1000m)?((balance>=5000m)?2.475f:1.621f):0.5f):3.213f);
    public static decimal Interest(decimal balance)=> ((decimal)InterestRate(balance) * balance/100);
    public static decimal AnnualBalanceUpdate(decimal balance)=> balance + Interest(balance);
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)=>((balance<targetBalance)?(1+YearsBeforeDesiredBalance(AnnualBalanceUpdate(balance),targetBalance)):0);
}
