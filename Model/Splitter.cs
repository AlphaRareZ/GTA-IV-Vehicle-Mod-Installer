namespace C__MOD_INSTALLER.Model;

abstract class Splitter
{
    public static List<string> SplitComma(string? s)
    {
        List<string> list = new List<string>();
        s += ',';
        string temp = "";
        foreach (var t in s)
        {
            if (t == ',')
            {
                if (temp != "")
                    list.Add(temp);
                temp = "";
            }
            else if (t == ' ' || t == '\t') continue;
            else
            {
                temp += t;
            }
        }

        return list;
    }

    public static List<string> SplitSpace(string? s)
    {
        List<string> list = new List<string>();
        s += ',';
        string temp = "";
        foreach (var t in s)
        {
            if (t == ' ' || t == '\t')
            {
                if (temp != "")
                    list.Add(temp);
                temp = "";
            }
            else
            {
                temp += t;
            }
        }

        return list;
    }
}