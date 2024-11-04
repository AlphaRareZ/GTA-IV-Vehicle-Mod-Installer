namespace C__MOD_INSTALLER.Model;

abstract class Splitter
{
    public static List<String> SplitAndTrim(string text, char delimiter)
    {
        var list = text.Split(delimiter).ToList();
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].Trim();
        }
        return list;
    }
}