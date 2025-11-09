static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var d = (department??"OWNER").ToUpper();
        return (id!=null) ? $"[{id}] - {name} - {d}" : $"{name} - {d}";
    }
}
