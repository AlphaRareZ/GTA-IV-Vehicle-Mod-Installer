namespace C__MOD_INSTALLER.Model;

public static class Splitter
{
    public static List<string>? SplitAndTrim(string text, char delimiter)
    {
        var result = (from i in text.Split(delimiter) where i.Length > 0 select i.Trim()).ToList();
        return result.Count == 0 ? null : result;
    }
}