namespace C__MOD_INSTALLER.Model;

public class GameData
{
    public string RetrieveVehicleData(string vehicleName)
    {
        try
        {
            using StreamReader sr = new StreamReader(Path.Combine(ModInstaller.GetGameDir(), @"common\data\vehicles.ide"));
            while (sr.ReadLine()! is { } line)
            {
                if (line.StartsWith(vehicleName))
                {
                    return line;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(@"The file could not be read:");
            Console.WriteLine(e.Message);
        }

        return string.Empty;
    }
}