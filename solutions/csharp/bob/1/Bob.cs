using System;
using System.Linq;
public static class Bob
{
    public static string Response(string statement)=>!(statement.Any(c=>!char.IsWhiteSpace(c)))?"Fine. Be that way!":(statement==statement.ToUpper()&& (!statement.EndsWith("?")&&statement.Any(c=>char.IsLetter(c))))?"Whoa, chill out!":(statement.Trim().EndsWith("?") && ((!statement.Any(c=>char.IsDigit(c)) && statement.Any(c=>char.IsLetter(c)))&&(statement==statement.ToUpper())))?"Calm down, I know what I'm doing!":(statement.Trim().EndsWith("?"))?"Sure.":"Whatever.";
}