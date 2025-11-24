public static class Acronym
{
    public static string Abbreviate(string phrase)=>string.Concat(phrase.ToUpper().Split([' ','_','-'],StringSplitOptions.RemoveEmptyEntries).Select(c=>c[0]));
}